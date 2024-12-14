using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009F3 RID: 2547
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveChallengeScRsp : IMessage<LeaveChallengeScRsp>, IMessage, IEquatable<LeaveChallengeScRsp>, IDeepCloneable<LeaveChallengeScRsp>, IBufferMessage
	{
		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600710F RID: 28943 RVA: 0x0012D2A4 File Offset: 0x0012B4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveChallengeScRsp> Parser
		{
			get
			{
				return LeaveChallengeScRsp._parser;
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06007110 RID: 28944 RVA: 0x0012D2AB File Offset: 0x0012B4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x0012D2BD File Offset: 0x0012B4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x0012D2C4 File Offset: 0x0012B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeScRsp()
		{
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x0012D2CC File Offset: 0x0012B4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeScRsp(LeaveChallengeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x0012D2F1 File Offset: 0x0012B4F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveChallengeScRsp Clone()
		{
			return new LeaveChallengeScRsp(this);
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06007115 RID: 28949 RVA: 0x0012D2F9 File Offset: 0x0012B4F9
		// (set) Token: 0x06007116 RID: 28950 RVA: 0x0012D301 File Offset: 0x0012B501
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

		// Token: 0x06007117 RID: 28951 RVA: 0x0012D30A File Offset: 0x0012B50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveChallengeScRsp);
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x0012D318 File Offset: 0x0012B518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveChallengeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x0012D348 File Offset: 0x0012B548
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

		// Token: 0x0600711A RID: 28954 RVA: 0x0012D387 File Offset: 0x0012B587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x0012D38F File Offset: 0x0012B58F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x0012D398 File Offset: 0x0012B598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x0012D3CC File Offset: 0x0012B5CC
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

		// Token: 0x0600711E RID: 28958 RVA: 0x0012D40A File Offset: 0x0012B60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveChallengeScRsp other)
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

		// Token: 0x0600711F RID: 28959 RVA: 0x0012D43B File Offset: 0x0012B63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x0012D444 File Offset: 0x0012B644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B8A RID: 11146
		private static readonly MessageParser<LeaveChallengeScRsp> _parser = new MessageParser<LeaveChallengeScRsp>(() => new LeaveChallengeScRsp());

		// Token: 0x04002B8B RID: 11147
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B8C RID: 11148
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04002B8D RID: 11149
		private uint retcode_;
	}
}
