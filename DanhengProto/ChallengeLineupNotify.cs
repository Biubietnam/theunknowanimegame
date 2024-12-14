using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001AB RID: 427
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeLineupNotify : IMessage<ChallengeLineupNotify>, IMessage, IEquatable<ChallengeLineupNotify>, IDeepCloneable<ChallengeLineupNotify>, IBufferMessage
	{
		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000377B1 File Offset: 0x000359B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeLineupNotify> Parser
		{
			get
			{
				return ChallengeLineupNotify._parser;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x000377B8 File Offset: 0x000359B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeLineupNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000377CA File Offset: 0x000359CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeLineupNotify.Descriptor;
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000377D1 File Offset: 0x000359D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupNotify()
		{
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000377D9 File Offset: 0x000359D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupNotify(ChallengeLineupNotify other) : this()
		{
			this.extraLineupType_ = other.extraLineupType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000377FE File Offset: 0x000359FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeLineupNotify Clone()
		{
			return new ChallengeLineupNotify(this);
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x00037806 File Offset: 0x00035A06
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x0003780E File Offset: 0x00035A0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExtraLineupType ExtraLineupType
		{
			get
			{
				return this.extraLineupType_;
			}
			set
			{
				this.extraLineupType_ = value;
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00037817 File Offset: 0x00035A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeLineupNotify);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00037825 File Offset: 0x00035A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeLineupNotify other)
		{
			return other != null && (other == this || (this.ExtraLineupType == other.ExtraLineupType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00037854 File Offset: 0x00035A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num ^= this.ExtraLineupType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00037899 File Offset: 0x00035A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000378A1 File Offset: 0x00035AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000378AA File Offset: 0x00035AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ExtraLineupType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000378DC File Offset: 0x00035ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ExtraLineupType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0003791A File Offset: 0x00035B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeLineupNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExtraLineupType != ExtraLineupType.LineupNone)
			{
				this.ExtraLineupType = other.ExtraLineupType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0003794B File Offset: 0x00035B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00037954 File Offset: 0x00035B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ExtraLineupType = (ExtraLineupType)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400081B RID: 2075
		private static readonly MessageParser<ChallengeLineupNotify> _parser = new MessageParser<ChallengeLineupNotify>(() => new ChallengeLineupNotify());

		// Token: 0x0400081C RID: 2076
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400081D RID: 2077
		public const int ExtraLineupTypeFieldNumber = 9;

		// Token: 0x0400081E RID: 2078
		private ExtraLineupType extraLineupType_;
	}
}
