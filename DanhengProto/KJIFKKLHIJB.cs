using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009B7 RID: 2487
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KJIFKKLHIJB : IMessage<KJIFKKLHIJB>, IMessage, IEquatable<KJIFKKLHIJB>, IDeepCloneable<KJIFKKLHIJB>, IBufferMessage
	{
		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06006F29 RID: 28457 RVA: 0x00128E5C File Offset: 0x0012705C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KJIFKKLHIJB> Parser
		{
			get
			{
				return KJIFKKLHIJB._parser;
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x00128E63 File Offset: 0x00127063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KJIFKKLHIJBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06006F2B RID: 28459 RVA: 0x00128E75 File Offset: 0x00127075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KJIFKKLHIJB.Descriptor;
			}
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00128E7C File Offset: 0x0012707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJIFKKLHIJB()
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00128E84 File Offset: 0x00127084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJIFKKLHIJB(KJIFKKLHIJB other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00128EA9 File Offset: 0x001270A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KJIFKKLHIJB Clone()
		{
			return new KJIFKKLHIJB(this);
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06006F2F RID: 28463 RVA: 0x00128EB1 File Offset: 0x001270B1
		// (set) Token: 0x06006F30 RID: 28464 RVA: 0x00128EB9 File Offset: 0x001270B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x00128EC2 File Offset: 0x001270C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KJIFKKLHIJB);
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x00128ED0 File Offset: 0x001270D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KJIFKKLHIJB other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x00128F00 File Offset: 0x00127100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00128F3F File Offset: 0x0012713F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F35 RID: 28469 RVA: 0x00128F47 File Offset: 0x00127147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F36 RID: 28470 RVA: 0x00128F50 File Offset: 0x00127150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F37 RID: 28471 RVA: 0x00128F84 File Offset: 0x00127184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F38 RID: 28472 RVA: 0x00128FC2 File Offset: 0x001271C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KJIFKKLHIJB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F39 RID: 28473 RVA: 0x00128FF3 File Offset: 0x001271F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F3A RID: 28474 RVA: 0x00128FFC File Offset: 0x001271FC
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
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002AB4 RID: 10932
		private static readonly MessageParser<KJIFKKLHIJB> _parser = new MessageParser<KJIFKKLHIJB>(() => new KJIFKKLHIJB());

		// Token: 0x04002AB5 RID: 10933
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AB6 RID: 10934
		public const int ChallengeIdFieldNumber = 7;

		// Token: 0x04002AB7 RID: 10935
		private uint challengeId_;
	}
}
