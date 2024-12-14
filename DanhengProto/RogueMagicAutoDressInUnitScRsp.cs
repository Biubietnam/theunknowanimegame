using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB3 RID: 3763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicAutoDressInUnitScRsp : IMessage<RogueMagicAutoDressInUnitScRsp>, IMessage, IEquatable<RogueMagicAutoDressInUnitScRsp>, IDeepCloneable<RogueMagicAutoDressInUnitScRsp>, IBufferMessage
	{
		// Token: 0x17002F7E RID: 12158
		// (get) Token: 0x0600A81F RID: 43039 RVA: 0x001C4C9C File Offset: 0x001C2E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicAutoDressInUnitScRsp> Parser
		{
			get
			{
				return RogueMagicAutoDressInUnitScRsp._parser;
			}
		}

		// Token: 0x17002F7F RID: 12159
		// (get) Token: 0x0600A820 RID: 43040 RVA: 0x001C4CA3 File Offset: 0x001C2EA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicAutoDressInUnitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F80 RID: 12160
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x001C4CB5 File Offset: 0x001C2EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicAutoDressInUnitScRsp.Descriptor;
			}
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x001C4CBC File Offset: 0x001C2EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitScRsp()
		{
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x001C4CC4 File Offset: 0x001C2EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitScRsp(RogueMagicAutoDressInUnitScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x001C4CE9 File Offset: 0x001C2EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicAutoDressInUnitScRsp Clone()
		{
			return new RogueMagicAutoDressInUnitScRsp(this);
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x0600A825 RID: 43045 RVA: 0x001C4CF1 File Offset: 0x001C2EF1
		// (set) Token: 0x0600A826 RID: 43046 RVA: 0x001C4CF9 File Offset: 0x001C2EF9
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

		// Token: 0x0600A827 RID: 43047 RVA: 0x001C4D02 File Offset: 0x001C2F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicAutoDressInUnitScRsp);
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x001C4D10 File Offset: 0x001C2F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicAutoDressInUnitScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x001C4D40 File Offset: 0x001C2F40
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

		// Token: 0x0600A82A RID: 43050 RVA: 0x001C4D7F File Offset: 0x001C2F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x001C4D87 File Offset: 0x001C2F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x001C4D90 File Offset: 0x001C2F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A82D RID: 43053 RVA: 0x001C4DC4 File Offset: 0x001C2FC4
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

		// Token: 0x0600A82E RID: 43054 RVA: 0x001C4E02 File Offset: 0x001C3002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicAutoDressInUnitScRsp other)
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

		// Token: 0x0600A82F RID: 43055 RVA: 0x001C4E33 File Offset: 0x001C3033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x001C4E3C File Offset: 0x001C303C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040044BA RID: 17594
		private static readonly MessageParser<RogueMagicAutoDressInUnitScRsp> _parser = new MessageParser<RogueMagicAutoDressInUnitScRsp>(() => new RogueMagicAutoDressInUnitScRsp());

		// Token: 0x040044BB RID: 17595
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044BC RID: 17596
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040044BD RID: 17597
		private uint retcode_;
	}
}
