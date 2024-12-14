using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000053 RID: 83
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideFinishChallengeScNotify : IMessage<AetherDivideFinishChallengeScNotify>, IMessage, IEquatable<AetherDivideFinishChallengeScNotify>, IDeepCloneable<AetherDivideFinishChallengeScNotify>, IBufferMessage
	{
		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000AE0D File Offset: 0x0000900D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideFinishChallengeScNotify> Parser
		{
			get
			{
				return AetherDivideFinishChallengeScNotify._parser;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000AE14 File Offset: 0x00009014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideFinishChallengeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0000AE26 File Offset: 0x00009026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideFinishChallengeScNotify.Descriptor;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000AE2D File Offset: 0x0000902D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideFinishChallengeScNotify()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000AE35 File Offset: 0x00009035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideFinishChallengeScNotify(AetherDivideFinishChallengeScNotify other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000AE5A File Offset: 0x0000905A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideFinishChallengeScNotify Clone()
		{
			return new AetherDivideFinishChallengeScNotify(this);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0000AE62 File Offset: 0x00009062
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0000AE6A File Offset: 0x0000906A
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

		// Token: 0x06000372 RID: 882 RVA: 0x0000AE73 File Offset: 0x00009073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideFinishChallengeScNotify);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000AE81 File Offset: 0x00009081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideFinishChallengeScNotify other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000AEB0 File Offset: 0x000090B0
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

		// Token: 0x06000375 RID: 885 RVA: 0x0000AEEF File Offset: 0x000090EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000AEF7 File Offset: 0x000090F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000AF00 File Offset: 0x00009100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000AF34 File Offset: 0x00009134
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

		// Token: 0x06000379 RID: 889 RVA: 0x0000AF72 File Offset: 0x00009172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideFinishChallengeScNotify other)
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

		// Token: 0x0600037A RID: 890 RVA: 0x0000AFA3 File Offset: 0x000091A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000AFAC File Offset: 0x000091AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000152 RID: 338
		private static readonly MessageParser<AetherDivideFinishChallengeScNotify> _parser = new MessageParser<AetherDivideFinishChallengeScNotify>(() => new AetherDivideFinishChallengeScNotify());

		// Token: 0x04000153 RID: 339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000154 RID: 340
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04000155 RID: 341
		private uint challengeId_;
	}
}
