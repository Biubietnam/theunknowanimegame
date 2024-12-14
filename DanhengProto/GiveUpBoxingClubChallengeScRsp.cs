using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000861 RID: 2145
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GiveUpBoxingClubChallengeScRsp : IMessage<GiveUpBoxingClubChallengeScRsp>, IMessage, IEquatable<GiveUpBoxingClubChallengeScRsp>, IDeepCloneable<GiveUpBoxingClubChallengeScRsp>, IBufferMessage
	{
		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06005F67 RID: 24423 RVA: 0x000FC6BF File Offset: 0x000FA8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiveUpBoxingClubChallengeScRsp> Parser
		{
			get
			{
				return GiveUpBoxingClubChallengeScRsp._parser;
			}
		}

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06005F68 RID: 24424 RVA: 0x000FC6C6 File Offset: 0x000FA8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GiveUpBoxingClubChallengeScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06005F69 RID: 24425 RVA: 0x000FC6D8 File Offset: 0x000FA8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiveUpBoxingClubChallengeScRsp.Descriptor;
			}
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x000FC6DF File Offset: 0x000FA8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeScRsp()
		{
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x000FC6E8 File Offset: 0x000FA8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeScRsp(GiveUpBoxingClubChallengeScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.challenge_ = ((other.challenge_ != null) ? other.challenge_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x000FC734 File Offset: 0x000FA934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiveUpBoxingClubChallengeScRsp Clone()
		{
			return new GiveUpBoxingClubChallengeScRsp(this);
		}

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06005F6D RID: 24429 RVA: 0x000FC73C File Offset: 0x000FA93C
		// (set) Token: 0x06005F6E RID: 24430 RVA: 0x000FC744 File Offset: 0x000FA944
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06005F6F RID: 24431 RVA: 0x000FC74D File Offset: 0x000FA94D
		// (set) Token: 0x06005F70 RID: 24432 RVA: 0x000FC755 File Offset: 0x000FA955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH Challenge
		{
			get
			{
				return this.challenge_;
			}
			set
			{
				this.challenge_ = value;
			}
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x000FC75E File Offset: 0x000FA95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiveUpBoxingClubChallengeScRsp);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x000FC76C File Offset: 0x000FA96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiveUpBoxingClubChallengeScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Challenge, other.Challenge) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x000FC7BC File Offset: 0x000FA9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.challenge_ != null)
			{
				num ^= this.Challenge.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x000FC811 File Offset: 0x000FAA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x000FC819 File Offset: 0x000FAA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x000FC824 File Offset: 0x000FAA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.challenge_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x000FC880 File Offset: 0x000FAA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.challenge_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Challenge);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x000FC8D8 File Offset: 0x000FAAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiveUpBoxingClubChallengeScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.challenge_ != null)
			{
				if (this.challenge_ == null)
				{
					this.Challenge = new LJLLHIJKKOH();
				}
				this.Challenge.MergeFrom(other.Challenge);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x000FC940 File Offset: 0x000FAB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x000FC94C File Offset: 0x000FAB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.challenge_ == null)
						{
							this.Challenge = new LJLLHIJKKOH();
						}
						input.ReadMessage(this.Challenge);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040024B4 RID: 9396
		private static readonly MessageParser<GiveUpBoxingClubChallengeScRsp> _parser = new MessageParser<GiveUpBoxingClubChallengeScRsp>(() => new GiveUpBoxingClubChallengeScRsp());

		// Token: 0x040024B5 RID: 9397
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024B6 RID: 9398
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040024B7 RID: 9399
		private uint retcode_;

		// Token: 0x040024B8 RID: 9400
		public const int ChallengeFieldNumber = 12;

		// Token: 0x040024B9 RID: 9401
		private LJLLHIJKKOH challenge_;
	}
}
