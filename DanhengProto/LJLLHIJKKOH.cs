using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A1B RID: 2587
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LJLLHIJKKOH : IMessage<LJLLHIJKKOH>, IMessage, IEquatable<LJLLHIJKKOH>, IDeepCloneable<LJLLHIJKKOH>, IBufferMessage
	{
		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x060072F3 RID: 29427 RVA: 0x00132155 File Offset: 0x00130355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LJLLHIJKKOH> Parser
		{
			get
			{
				return LJLLHIJKKOH._parser;
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x060072F4 RID: 29428 RVA: 0x0013215C File Offset: 0x0013035C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LJLLHIJKKOHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x060072F5 RID: 29429 RVA: 0x0013216E File Offset: 0x0013036E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LJLLHIJKKOH.Descriptor;
			}
		}

		// Token: 0x060072F6 RID: 29430 RVA: 0x00132175 File Offset: 0x00130375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH()
		{
		}

		// Token: 0x060072F7 RID: 29431 RVA: 0x001321A0 File Offset: 0x001303A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH(LJLLHIJKKOH other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.cBAHJJCOGLM_ = other.cBAHJJCOGLM_.Clone();
			this.hHMFMFHCMOK_ = other.hHMFMFHCMOK_.Clone();
			this.gNGFBJNJMIA_ = other.gNGFBJNJMIA_;
			this.dJMKFKNCPJP_ = other.dJMKFKNCPJP_;
			this.jIBAEJKHDJA_ = other.jIBAEJKHDJA_;
			this.aDBHBEEHCMJ_ = other.aDBHBEEHCMJ_;
			this.gNNDAONOLIA_ = other.gNNDAONOLIA_;
			this.avatarList_ = other.avatarList_.Clone();
			this.fAHCBPNFKFO_ = other.fAHCBPNFKFO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072F8 RID: 29432 RVA: 0x0013224B File Offset: 0x0013044B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LJLLHIJKKOH Clone()
		{
			return new LJLLHIJKKOH(this);
		}

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x060072F9 RID: 29433 RVA: 0x00132253 File Offset: 0x00130453
		// (set) Token: 0x060072FA RID: 29434 RVA: 0x0013225B File Offset: 0x0013045B
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

		// Token: 0x17002058 RID: 8280
		// (get) Token: 0x060072FB RID: 29435 RVA: 0x00132264 File Offset: 0x00130464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> CBAHJJCOGLM
		{
			get
			{
				return this.cBAHJJCOGLM_;
			}
		}

		// Token: 0x17002059 RID: 8281
		// (get) Token: 0x060072FC RID: 29436 RVA: 0x0013226C File Offset: 0x0013046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KLIKDPDIJMI> HHMFMFHCMOK
		{
			get
			{
				return this.hHMFMFHCMOK_;
			}
		}

		// Token: 0x1700205A RID: 8282
		// (get) Token: 0x060072FD RID: 29437 RVA: 0x00132274 File Offset: 0x00130474
		// (set) Token: 0x060072FE RID: 29438 RVA: 0x0013227C File Offset: 0x0013047C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNGFBJNJMIA
		{
			get
			{
				return this.gNGFBJNJMIA_;
			}
			set
			{
				this.gNGFBJNJMIA_ = value;
			}
		}

		// Token: 0x1700205B RID: 8283
		// (get) Token: 0x060072FF RID: 29439 RVA: 0x00132285 File Offset: 0x00130485
		// (set) Token: 0x06007300 RID: 29440 RVA: 0x0013228D File Offset: 0x0013048D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJMKFKNCPJP
		{
			get
			{
				return this.dJMKFKNCPJP_;
			}
			set
			{
				this.dJMKFKNCPJP_ = value;
			}
		}

		// Token: 0x1700205C RID: 8284
		// (get) Token: 0x06007301 RID: 29441 RVA: 0x00132296 File Offset: 0x00130496
		// (set) Token: 0x06007302 RID: 29442 RVA: 0x0013229E File Offset: 0x0013049E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JIBAEJKHDJA
		{
			get
			{
				return this.jIBAEJKHDJA_;
			}
			set
			{
				this.jIBAEJKHDJA_ = value;
			}
		}

		// Token: 0x1700205D RID: 8285
		// (get) Token: 0x06007303 RID: 29443 RVA: 0x001322A7 File Offset: 0x001304A7
		// (set) Token: 0x06007304 RID: 29444 RVA: 0x001322AF File Offset: 0x001304AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ADBHBEEHCMJ
		{
			get
			{
				return this.aDBHBEEHCMJ_;
			}
			set
			{
				this.aDBHBEEHCMJ_ = value;
			}
		}

		// Token: 0x1700205E RID: 8286
		// (get) Token: 0x06007305 RID: 29445 RVA: 0x001322B8 File Offset: 0x001304B8
		// (set) Token: 0x06007306 RID: 29446 RVA: 0x001322C0 File Offset: 0x001304C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GNNDAONOLIA
		{
			get
			{
				return this.gNNDAONOLIA_;
			}
			set
			{
				this.gNNDAONOLIA_ = value;
			}
		}

		// Token: 0x1700205F RID: 8287
		// (get) Token: 0x06007307 RID: 29447 RVA: 0x001322C9 File Offset: 0x001304C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17002060 RID: 8288
		// (get) Token: 0x06007308 RID: 29448 RVA: 0x001322D1 File Offset: 0x001304D1
		// (set) Token: 0x06007309 RID: 29449 RVA: 0x001322D9 File Offset: 0x001304D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FAHCBPNFKFO
		{
			get
			{
				return this.fAHCBPNFKFO_;
			}
			set
			{
				this.fAHCBPNFKFO_ = value;
			}
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x001322E2 File Offset: 0x001304E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LJLLHIJKKOH);
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x001322F0 File Offset: 0x001304F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LJLLHIJKKOH other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.cBAHJJCOGLM_.Equals(other.cBAHJJCOGLM_) && this.hHMFMFHCMOK_.Equals(other.hHMFMFHCMOK_) && this.GNGFBJNJMIA == other.GNGFBJNJMIA && this.DJMKFKNCPJP == other.DJMKFKNCPJP && this.JIBAEJKHDJA == other.JIBAEJKHDJA && this.ADBHBEEHCMJ == other.ADBHBEEHCMJ && this.GNNDAONOLIA == other.GNNDAONOLIA && this.avatarList_.Equals(other.avatarList_) && this.FAHCBPNFKFO == other.FAHCBPNFKFO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x001323C8 File Offset: 0x001305C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0U)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.cBAHJJCOGLM_.GetHashCode();
			num ^= this.hHMFMFHCMOK_.GetHashCode();
			if (this.GNGFBJNJMIA)
			{
				num ^= this.GNGFBJNJMIA.GetHashCode();
			}
			if (this.DJMKFKNCPJP != 0U)
			{
				num ^= this.DJMKFKNCPJP.GetHashCode();
			}
			if (this.JIBAEJKHDJA != 0U)
			{
				num ^= this.JIBAEJKHDJA.GetHashCode();
			}
			if (this.ADBHBEEHCMJ != 0U)
			{
				num ^= this.ADBHBEEHCMJ.GetHashCode();
			}
			if (this.GNNDAONOLIA != 0U)
			{
				num ^= this.GNNDAONOLIA.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.FAHCBPNFKFO != 0U)
			{
				num ^= this.FAHCBPNFKFO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x001324C7 File Offset: 0x001306C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x001324CF File Offset: 0x001306CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x001324D8 File Offset: 0x001306D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GNGFBJNJMIA)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.GNGFBJNJMIA);
			}
			this.cBAHJJCOGLM_.WriteTo(ref output, LJLLHIJKKOH._repeated_cBAHJJCOGLM_codec);
			if (this.DJMKFKNCPJP != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DJMKFKNCPJP);
			}
			if (this.GNNDAONOLIA != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GNNDAONOLIA);
			}
			if (this.JIBAEJKHDJA != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.JIBAEJKHDJA);
			}
			if (this.ChallengeId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ChallengeId);
			}
			this.hHMFMFHCMOK_.WriteTo(ref output, LJLLHIJKKOH._repeated_hHMFMFHCMOK_codec);
			if (this.ADBHBEEHCMJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ADBHBEEHCMJ);
			}
			this.avatarList_.WriteTo(ref output, LJLLHIJKKOH._repeated_avatarList_codec);
			if (this.FAHCBPNFKFO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FAHCBPNFKFO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x001325F0 File Offset: 0x001307F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeId);
			}
			num += this.cBAHJJCOGLM_.CalculateSize(LJLLHIJKKOH._repeated_cBAHJJCOGLM_codec);
			num += this.hHMFMFHCMOK_.CalculateSize(LJLLHIJKKOH._repeated_hHMFMFHCMOK_codec);
			if (this.GNGFBJNJMIA)
			{
				num += 2;
			}
			if (this.DJMKFKNCPJP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJMKFKNCPJP);
			}
			if (this.JIBAEJKHDJA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JIBAEJKHDJA);
			}
			if (this.ADBHBEEHCMJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ADBHBEEHCMJ);
			}
			if (this.GNNDAONOLIA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GNNDAONOLIA);
			}
			num += this.avatarList_.CalculateSize(LJLLHIJKKOH._repeated_avatarList_codec);
			if (this.FAHCBPNFKFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FAHCBPNFKFO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x001326EC File Offset: 0x001308EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LJLLHIJKKOH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0U)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.cBAHJJCOGLM_.Add(other.cBAHJJCOGLM_);
			this.hHMFMFHCMOK_.Add(other.hHMFMFHCMOK_);
			if (other.GNGFBJNJMIA)
			{
				this.GNGFBJNJMIA = other.GNGFBJNJMIA;
			}
			if (other.DJMKFKNCPJP != 0U)
			{
				this.DJMKFKNCPJP = other.DJMKFKNCPJP;
			}
			if (other.JIBAEJKHDJA != 0U)
			{
				this.JIBAEJKHDJA = other.JIBAEJKHDJA;
			}
			if (other.ADBHBEEHCMJ != 0U)
			{
				this.ADBHBEEHCMJ = other.ADBHBEEHCMJ;
			}
			if (other.GNNDAONOLIA != 0U)
			{
				this.GNNDAONOLIA = other.GNNDAONOLIA;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.FAHCBPNFKFO != 0U)
			{
				this.FAHCBPNFKFO = other.FAHCBPNFKFO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x001327D3 File Offset: 0x001309D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x001327DC File Offset: 0x001309DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num <= 26U)
					{
						if (num == 8U)
						{
							this.GNGFBJNJMIA = input.ReadBool();
							continue;
						}
						if (num == 24U || num == 26U)
						{
							this.cBAHJJCOGLM_.AddEntriesFrom(ref input, LJLLHIJKKOH._repeated_cBAHJJCOGLM_codec);
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.DJMKFKNCPJP = input.ReadUInt32();
							continue;
						}
						if (num == 48U)
						{
							this.GNNDAONOLIA = input.ReadUInt32();
							continue;
						}
						if (num == 56U)
						{
							this.JIBAEJKHDJA = input.ReadUInt32();
							continue;
						}
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.ChallengeId = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.hHMFMFHCMOK_.AddEntriesFrom(ref input, LJLLHIJKKOH._repeated_hHMFMFHCMOK_codec);
						continue;
					}
					if (num == 96U)
					{
						this.ADBHBEEHCMJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U || num == 106U)
					{
						this.avatarList_.AddEntriesFrom(ref input, LJLLHIJKKOH._repeated_avatarList_codec);
						continue;
					}
					if (num == 112U)
					{
						this.FAHCBPNFKFO = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C3A RID: 11322
		private static readonly MessageParser<LJLLHIJKKOH> _parser = new MessageParser<LJLLHIJKKOH>(() => new LJLLHIJKKOH());

		// Token: 0x04002C3B RID: 11323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C3C RID: 11324
		public const int ChallengeIdFieldNumber = 10;

		// Token: 0x04002C3D RID: 11325
		private uint challengeId_;

		// Token: 0x04002C3E RID: 11326
		public const int CBAHJJCOGLMFieldNumber = 3;

		// Token: 0x04002C3F RID: 11327
		private static readonly FieldCodec<uint> _repeated_cBAHJJCOGLM_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002C40 RID: 11328
		private readonly RepeatedField<uint> cBAHJJCOGLM_ = new RepeatedField<uint>();

		// Token: 0x04002C41 RID: 11329
		public const int HHMFMFHCMOKFieldNumber = 11;

		// Token: 0x04002C42 RID: 11330
		private static readonly FieldCodec<KLIKDPDIJMI> _repeated_hHMFMFHCMOK_codec = FieldCodec.ForMessage<KLIKDPDIJMI>(90U, KLIKDPDIJMI.Parser);

		// Token: 0x04002C43 RID: 11331
		private readonly RepeatedField<KLIKDPDIJMI> hHMFMFHCMOK_ = new RepeatedField<KLIKDPDIJMI>();

		// Token: 0x04002C44 RID: 11332
		public const int GNGFBJNJMIAFieldNumber = 1;

		// Token: 0x04002C45 RID: 11333
		private bool gNGFBJNJMIA_;

		// Token: 0x04002C46 RID: 11334
		public const int DJMKFKNCPJPFieldNumber = 4;

		// Token: 0x04002C47 RID: 11335
		private uint dJMKFKNCPJP_;

		// Token: 0x04002C48 RID: 11336
		public const int JIBAEJKHDJAFieldNumber = 7;

		// Token: 0x04002C49 RID: 11337
		private uint jIBAEJKHDJA_;

		// Token: 0x04002C4A RID: 11338
		public const int ADBHBEEHCMJFieldNumber = 12;

		// Token: 0x04002C4B RID: 11339
		private uint aDBHBEEHCMJ_;

		// Token: 0x04002C4C RID: 11340
		public const int GNNDAONOLIAFieldNumber = 6;

		// Token: 0x04002C4D RID: 11341
		private uint gNNDAONOLIA_;

		// Token: 0x04002C4E RID: 11342
		public const int AvatarListFieldNumber = 13;

		// Token: 0x04002C4F RID: 11343
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04002C50 RID: 11344
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

		// Token: 0x04002C51 RID: 11345
		public const int FAHCBPNFKFOFieldNumber = 14;

		// Token: 0x04002C52 RID: 11346
		private uint fAHCBPNFKFO_;
	}
}
