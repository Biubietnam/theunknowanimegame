using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200097F RID: 2431
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JoinLineupScRsp : IMessage<JoinLineupScRsp>, IMessage, IEquatable<JoinLineupScRsp>, IDeepCloneable<JoinLineupScRsp>, IBufferMessage
	{
		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06006CBE RID: 27838 RVA: 0x00122740 File Offset: 0x00120940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JoinLineupScRsp> Parser
		{
			get
			{
				return JoinLineupScRsp._parser;
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x00122747 File Offset: 0x00120947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JoinLineupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x00122759 File Offset: 0x00120959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JoinLineupScRsp.Descriptor;
			}
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x00122760 File Offset: 0x00120960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupScRsp()
		{
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x00122768 File Offset: 0x00120968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupScRsp(JoinLineupScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x0012278D File Offset: 0x0012098D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JoinLineupScRsp Clone()
		{
			return new JoinLineupScRsp(this);
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x00122795 File Offset: 0x00120995
		// (set) Token: 0x06006CC5 RID: 27845 RVA: 0x0012279D File Offset: 0x0012099D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x001227A6 File Offset: 0x001209A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JoinLineupScRsp);
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x001227B4 File Offset: 0x001209B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JoinLineupScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x001227E4 File Offset: 0x001209E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00122823 File Offset: 0x00120A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x0012282B File Offset: 0x00120A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00122834 File Offset: 0x00120A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00122868 File Offset: 0x00120A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x001228A6 File Offset: 0x00120AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JoinLineupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x001228D7 File Offset: 0x00120AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x001228E0 File Offset: 0x00120AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040029B2 RID: 10674
		private static readonly MessageParser<JoinLineupScRsp> _parser = new MessageParser<JoinLineupScRsp>(() => new JoinLineupScRsp());

		// Token: 0x040029B3 RID: 10675
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B4 RID: 10676
		public const int RetcodeFieldNumber = 7;

		// Token: 0x040029B5 RID: 10677
		private uint retcode_;
	}
}
