using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000027 RID: 39
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AceAntiCheaterScRsp : IMessage<AceAntiCheaterScRsp>, IMessage, IEquatable<AceAntiCheaterScRsp>, IDeepCloneable<AceAntiCheaterScRsp>, IBufferMessage
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000053E0 File Offset: 0x000035E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AceAntiCheaterScRsp> Parser
		{
			get
			{
				return AceAntiCheaterScRsp._parser;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000053E7 File Offset: 0x000035E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AceAntiCheaterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000053F9 File Offset: 0x000035F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AceAntiCheaterScRsp.Descriptor;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005400 File Offset: 0x00003600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterScRsp()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005408 File Offset: 0x00003608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterScRsp(AceAntiCheaterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000542D File Offset: 0x0000362D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceAntiCheaterScRsp Clone()
		{
			return new AceAntiCheaterScRsp(this);
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00005435 File Offset: 0x00003635
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0000543D File Offset: 0x0000363D
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

		// Token: 0x06000172 RID: 370 RVA: 0x00005446 File Offset: 0x00003646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AceAntiCheaterScRsp);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005454 File Offset: 0x00003654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AceAntiCheaterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005484 File Offset: 0x00003684
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

		// Token: 0x06000175 RID: 373 RVA: 0x000054C3 File Offset: 0x000036C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000054CB File Offset: 0x000036CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000054D4 File Offset: 0x000036D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005508 File Offset: 0x00003708
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

		// Token: 0x06000179 RID: 377 RVA: 0x00005546 File Offset: 0x00003746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AceAntiCheaterScRsp other)
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

		// Token: 0x0600017A RID: 378 RVA: 0x00005577 File Offset: 0x00003777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005580 File Offset: 0x00003780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly MessageParser<AceAntiCheaterScRsp> _parser = new MessageParser<AceAntiCheaterScRsp>(() => new AceAntiCheaterScRsp());

		// Token: 0x04000079 RID: 121
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400007A RID: 122
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400007B RID: 123
		private uint retcode_;
	}
}
