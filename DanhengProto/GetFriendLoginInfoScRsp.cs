using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006CF RID: 1743
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFriendLoginInfoScRsp : IMessage<GetFriendLoginInfoScRsp>, IMessage, IEquatable<GetFriendLoginInfoScRsp>, IDeepCloneable<GetFriendLoginInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06004DFB RID: 19963 RVA: 0x000D31EF File Offset: 0x000D13EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFriendLoginInfoScRsp> Parser
		{
			get
			{
				return GetFriendLoginInfoScRsp._parser;
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x000D31F6 File Offset: 0x000D13F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFriendLoginInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06004DFD RID: 19965 RVA: 0x000D3208 File Offset: 0x000D1408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFriendLoginInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x000D320F File Offset: 0x000D140F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoScRsp()
		{
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x000D3230 File Offset: 0x000D1430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoScRsp(GetFriendLoginInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.friendUidList_ = other.friendUidList_.Clone();
			this.aIHPMJLCBCH_ = other.aIHPMJLCBCH_;
			this.eAPDPOACPMO_ = other.eAPDPOACPMO_;
			this.jNOHFKLKNHO_ = other.jNOHFKLKNHO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x000D329A File Offset: 0x000D149A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFriendLoginInfoScRsp Clone()
		{
			return new GetFriendLoginInfoScRsp(this);
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004E01 RID: 19969 RVA: 0x000D32A2 File Offset: 0x000D14A2
		// (set) Token: 0x06004E02 RID: 19970 RVA: 0x000D32AA File Offset: 0x000D14AA
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06004E03 RID: 19971 RVA: 0x000D32B3 File Offset: 0x000D14B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FriendUidList
		{
			get
			{
				return this.friendUidList_;
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x000D32BB File Offset: 0x000D14BB
		// (set) Token: 0x06004E05 RID: 19973 RVA: 0x000D32C3 File Offset: 0x000D14C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AIHPMJLCBCH
		{
			get
			{
				return this.aIHPMJLCBCH_;
			}
			set
			{
				this.aIHPMJLCBCH_ = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x000D32CC File Offset: 0x000D14CC
		// (set) Token: 0x06004E07 RID: 19975 RVA: 0x000D32D4 File Offset: 0x000D14D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EAPDPOACPMO
		{
			get
			{
				return this.eAPDPOACPMO_;
			}
			set
			{
				this.eAPDPOACPMO_ = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x000D32DD File Offset: 0x000D14DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JNOHFKLKNHO
		{
			get
			{
				return this.jNOHFKLKNHO_;
			}
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x000D32E5 File Offset: 0x000D14E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFriendLoginInfoScRsp);
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x000D32F4 File Offset: 0x000D14F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFriendLoginInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.friendUidList_.Equals(other.friendUidList_) && this.AIHPMJLCBCH == other.AIHPMJLCBCH && this.EAPDPOACPMO == other.EAPDPOACPMO && this.jNOHFKLKNHO_.Equals(other.jNOHFKLKNHO_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x000D3378 File Offset: 0x000D1578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.friendUidList_.GetHashCode();
			if (this.AIHPMJLCBCH)
			{
				num ^= this.AIHPMJLCBCH.GetHashCode();
			}
			if (this.EAPDPOACPMO)
			{
				num ^= this.EAPDPOACPMO.GetHashCode();
			}
			num ^= this.jNOHFKLKNHO_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x000D3405 File Offset: 0x000D1605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x000D340D File Offset: 0x000D160D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x000D3418 File Offset: 0x000D1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			this.jNOHFKLKNHO_.WriteTo(ref output, GetFriendLoginInfoScRsp._repeated_jNOHFKLKNHO_codec);
			if (this.EAPDPOACPMO)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.EAPDPOACPMO);
			}
			this.friendUidList_.WriteTo(ref output, GetFriendLoginInfoScRsp._repeated_friendUidList_codec);
			if (this.AIHPMJLCBCH)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.AIHPMJLCBCH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x000D34B0 File Offset: 0x000D16B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.friendUidList_.CalculateSize(GetFriendLoginInfoScRsp._repeated_friendUidList_codec);
			if (this.AIHPMJLCBCH)
			{
				num += 2;
			}
			if (this.EAPDPOACPMO)
			{
				num += 2;
			}
			num += this.jNOHFKLKNHO_.CalculateSize(GetFriendLoginInfoScRsp._repeated_jNOHFKLKNHO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x000D352C File Offset: 0x000D172C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFriendLoginInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.friendUidList_.Add(other.friendUidList_);
			if (other.AIHPMJLCBCH)
			{
				this.AIHPMJLCBCH = other.AIHPMJLCBCH;
			}
			if (other.EAPDPOACPMO)
			{
				this.EAPDPOACPMO = other.EAPDPOACPMO;
			}
			this.jNOHFKLKNHO_.Add(other.jNOHFKLKNHO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x000D35B2 File Offset: 0x000D17B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x000D35BC File Offset: 0x000D17BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 66U)
				{
					if (num <= 88U)
					{
						if (num == 72U)
						{
							this.EAPDPOACPMO = input.ReadBool();
							continue;
						}
						if (num != 88U)
						{
							goto IL_36;
						}
					}
					else if (num != 90U)
					{
						if (num != 96U)
						{
							goto IL_36;
						}
						this.AIHPMJLCBCH = input.ReadBool();
						continue;
					}
					this.friendUidList_.AddEntriesFrom(ref input, GetFriendLoginInfoScRsp._repeated_friendUidList_codec);
					continue;
				}
				if (num == 16U)
				{
					this.Retcode = input.ReadUInt32();
					continue;
				}
				if (num == 64U || num == 66U)
				{
					this.jNOHFKLKNHO_.AddEntriesFrom(ref input, GetFriendLoginInfoScRsp._repeated_jNOHFKLKNHO_codec);
					continue;
				}
				IL_36:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001ECD RID: 7885
		private static readonly MessageParser<GetFriendLoginInfoScRsp> _parser = new MessageParser<GetFriendLoginInfoScRsp>(() => new GetFriendLoginInfoScRsp());

		// Token: 0x04001ECE RID: 7886
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001ECF RID: 7887
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04001ED0 RID: 7888
		private uint retcode_;

		// Token: 0x04001ED1 RID: 7889
		public const int FriendUidListFieldNumber = 11;

		// Token: 0x04001ED2 RID: 7890
		private static readonly FieldCodec<uint> _repeated_friendUidList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04001ED3 RID: 7891
		private readonly RepeatedField<uint> friendUidList_ = new RepeatedField<uint>();

		// Token: 0x04001ED4 RID: 7892
		public const int AIHPMJLCBCHFieldNumber = 12;

		// Token: 0x04001ED5 RID: 7893
		private bool aIHPMJLCBCH_;

		// Token: 0x04001ED6 RID: 7894
		public const int EAPDPOACPMOFieldNumber = 9;

		// Token: 0x04001ED7 RID: 7895
		private bool eAPDPOACPMO_;

		// Token: 0x04001ED8 RID: 7896
		public const int JNOHFKLKNHOFieldNumber = 8;

		// Token: 0x04001ED9 RID: 7897
		private static readonly FieldCodec<uint> _repeated_jNOHFKLKNHO_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001EDA RID: 7898
		private readonly RepeatedField<uint> jNOHFKLKNHO_ = new RepeatedField<uint>();
	}
}
