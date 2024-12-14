using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000639 RID: 1593
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetBoxingClubInfoScRsp : IMessage<GetBoxingClubInfoScRsp>, IMessage, IEquatable<GetBoxingClubInfoScRsp>, IDeepCloneable<GetBoxingClubInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x000C3DB9 File Offset: 0x000C1FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetBoxingClubInfoScRsp> Parser
		{
			get
			{
				return GetBoxingClubInfoScRsp._parser;
			}
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x000C3DC0 File Offset: 0x000C1FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetBoxingClubInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06004781 RID: 18305 RVA: 0x000C3DD2 File Offset: 0x000C1FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetBoxingClubInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x000C3DD9 File Offset: 0x000C1FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoScRsp()
		{
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x000C3DEC File Offset: 0x000C1FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoScRsp(GetBoxingClubInfoScRsp other) : this()
		{
			this.challengeList_ = other.challengeList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x000C3E22 File Offset: 0x000C2022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetBoxingClubInfoScRsp Clone()
		{
			return new GetBoxingClubInfoScRsp(this);
		}

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x000C3E2A File Offset: 0x000C202A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LJLLHIJKKOH> ChallengeList
		{
			get
			{
				return this.challengeList_;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x000C3E32 File Offset: 0x000C2032
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x000C3E3A File Offset: 0x000C203A
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

		// Token: 0x06004788 RID: 18312 RVA: 0x000C3E43 File Offset: 0x000C2043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetBoxingClubInfoScRsp);
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x000C3E54 File Offset: 0x000C2054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetBoxingClubInfoScRsp other)
		{
			return other != null && (other == this || (this.challengeList_.Equals(other.challengeList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x000C3EA4 File Offset: 0x000C20A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeList_.GetHashCode();
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

		// Token: 0x0600478B RID: 18315 RVA: 0x000C3EF1 File Offset: 0x000C20F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x000C3EF9 File Offset: 0x000C20F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x000C3F04 File Offset: 0x000C2104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.challengeList_.WriteTo(ref output, GetBoxingClubInfoScRsp._repeated_challengeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x000C3F54 File Offset: 0x000C2154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeList_.CalculateSize(GetBoxingClubInfoScRsp._repeated_challengeList_codec);
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

		// Token: 0x0600478F RID: 18319 RVA: 0x000C3FA8 File Offset: 0x000C21A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetBoxingClubInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeList_.Add(other.challengeList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x000C3FF5 File Offset: 0x000C21F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x000C4000 File Offset: 0x000C2200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.challengeList_.AddEntriesFrom(ref input, GetBoxingClubInfoScRsp._repeated_challengeList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001CA2 RID: 7330
		private static readonly MessageParser<GetBoxingClubInfoScRsp> _parser = new MessageParser<GetBoxingClubInfoScRsp>(() => new GetBoxingClubInfoScRsp());

		// Token: 0x04001CA3 RID: 7331
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001CA4 RID: 7332
		public const int ChallengeListFieldNumber = 14;

		// Token: 0x04001CA5 RID: 7333
		private static readonly FieldCodec<LJLLHIJKKOH> _repeated_challengeList_codec = FieldCodec.ForMessage<LJLLHIJKKOH>(114U, LJLLHIJKKOH.Parser);

		// Token: 0x04001CA6 RID: 7334
		private readonly RepeatedField<LJLLHIJKKOH> challengeList_ = new RepeatedField<LJLLHIJKKOH>();

		// Token: 0x04001CA7 RID: 7335
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04001CA8 RID: 7336
		private uint retcode_;
	}
}
