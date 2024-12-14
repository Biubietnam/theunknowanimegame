using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001293 RID: 4755
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueHandbookDataUpdateScNotify : IMessage<SyncRogueHandbookDataUpdateScNotify>, IMessage, IEquatable<SyncRogueHandbookDataUpdateScNotify>, IDeepCloneable<SyncRogueHandbookDataUpdateScNotify>, IBufferMessage
	{
		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600D420 RID: 54304 RVA: 0x00236629 File Offset: 0x00234829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueHandbookDataUpdateScNotify> Parser
		{
			get
			{
				return SyncRogueHandbookDataUpdateScNotify._parser;
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600D421 RID: 54305 RVA: 0x00236630 File Offset: 0x00234830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueHandbookDataUpdateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600D422 RID: 54306 RVA: 0x00236642 File Offset: 0x00234842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueHandbookDataUpdateScNotify.Descriptor;
			}
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x00236649 File Offset: 0x00234849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueHandbookDataUpdateScNotify()
		{
		}

		// Token: 0x0600D424 RID: 54308 RVA: 0x00236688 File Offset: 0x00234888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueHandbookDataUpdateScNotify(SyncRogueHandbookDataUpdateScNotify other) : this()
		{
			this.nNLPKGJLNHD_ = other.nNLPKGJLNHD_.Clone();
			this.pPIMHAIDMII_ = other.pPIMHAIDMII_.Clone();
			this.eCBFBBNGNPM_ = other.eCBFBBNGNPM_.Clone();
			this.jJPHKACOFHP_ = other.jJPHKACOFHP_.Clone();
			this.jDGHMMCMPJH_ = other.jDGHMMCMPJH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D425 RID: 54309 RVA: 0x00236701 File Offset: 0x00234901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueHandbookDataUpdateScNotify Clone()
		{
			return new SyncRogueHandbookDataUpdateScNotify(this);
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600D426 RID: 54310 RVA: 0x00236709 File Offset: 0x00234909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DMDEOGJEGPI> NNLPKGJLNHD
		{
			get
			{
				return this.nNLPKGJLNHD_;
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600D427 RID: 54311 RVA: 0x00236711 File Offset: 0x00234911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicScepterInfo> PPIMHAIDMII
		{
			get
			{
				return this.pPIMHAIDMII_;
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x00236719 File Offset: 0x00234919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BFDCJNAGBCH> ECBFBBNGNPM
		{
			get
			{
				return this.eCBFBBNGNPM_;
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600D429 RID: 54313 RVA: 0x00236721 File Offset: 0x00234921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicUnitInfo> JJPHKACOFHP
		{
			get
			{
				return this.jJPHKACOFHP_;
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600D42A RID: 54314 RVA: 0x00236729 File Offset: 0x00234929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueHandbookMazeBuff> JDGHMMCMPJH
		{
			get
			{
				return this.jDGHMMCMPJH_;
			}
		}

		// Token: 0x0600D42B RID: 54315 RVA: 0x00236731 File Offset: 0x00234931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueHandbookDataUpdateScNotify);
		}

		// Token: 0x0600D42C RID: 54316 RVA: 0x00236740 File Offset: 0x00234940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueHandbookDataUpdateScNotify other)
		{
			return other != null && (other == this || (this.nNLPKGJLNHD_.Equals(other.nNLPKGJLNHD_) && this.pPIMHAIDMII_.Equals(other.pPIMHAIDMII_) && this.eCBFBBNGNPM_.Equals(other.eCBFBBNGNPM_) && this.jJPHKACOFHP_.Equals(other.jJPHKACOFHP_) && this.jDGHMMCMPJH_.Equals(other.jDGHMMCMPJH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D42D RID: 54317 RVA: 0x002367D4 File Offset: 0x002349D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nNLPKGJLNHD_.GetHashCode();
			num ^= this.pPIMHAIDMII_.GetHashCode();
			num ^= this.eCBFBBNGNPM_.GetHashCode();
			num ^= this.jJPHKACOFHP_.GetHashCode();
			num ^= this.jDGHMMCMPJH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D42E RID: 54318 RVA: 0x00236840 File Offset: 0x00234A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D42F RID: 54319 RVA: 0x00236848 File Offset: 0x00234A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x00236854 File Offset: 0x00234A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jDGHMMCMPJH_.WriteTo(ref output, SyncRogueHandbookDataUpdateScNotify._repeated_jDGHMMCMPJH_codec);
			this.eCBFBBNGNPM_.WriteTo(ref output, SyncRogueHandbookDataUpdateScNotify._repeated_eCBFBBNGNPM_codec);
			this.jJPHKACOFHP_.WriteTo(ref output, SyncRogueHandbookDataUpdateScNotify._repeated_jJPHKACOFHP_codec);
			this.pPIMHAIDMII_.WriteTo(ref output, SyncRogueHandbookDataUpdateScNotify._repeated_pPIMHAIDMII_codec);
			this.nNLPKGJLNHD_.WriteTo(ref output, SyncRogueHandbookDataUpdateScNotify._repeated_nNLPKGJLNHD_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x002368CC File Offset: 0x00234ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nNLPKGJLNHD_.CalculateSize(SyncRogueHandbookDataUpdateScNotify._repeated_nNLPKGJLNHD_codec);
			num += this.pPIMHAIDMII_.CalculateSize(SyncRogueHandbookDataUpdateScNotify._repeated_pPIMHAIDMII_codec);
			num += this.eCBFBBNGNPM_.CalculateSize(SyncRogueHandbookDataUpdateScNotify._repeated_eCBFBBNGNPM_codec);
			num += this.jJPHKACOFHP_.CalculateSize(SyncRogueHandbookDataUpdateScNotify._repeated_jJPHKACOFHP_codec);
			num += this.jDGHMMCMPJH_.CalculateSize(SyncRogueHandbookDataUpdateScNotify._repeated_jDGHMMCMPJH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D432 RID: 54322 RVA: 0x00236954 File Offset: 0x00234B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueHandbookDataUpdateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.nNLPKGJLNHD_.Add(other.nNLPKGJLNHD_);
			this.pPIMHAIDMII_.Add(other.pPIMHAIDMII_);
			this.eCBFBBNGNPM_.Add(other.eCBFBBNGNPM_);
			this.jJPHKACOFHP_.Add(other.jJPHKACOFHP_);
			this.jDGHMMCMPJH_.Add(other.jDGHMMCMPJH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x002369D1 File Offset: 0x00234BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x002369DC File Offset: 0x00234BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 10U)
					{
						this.jDGHMMCMPJH_.AddEntriesFrom(ref input, SyncRogueHandbookDataUpdateScNotify._repeated_jDGHMMCMPJH_codec);
						continue;
					}
					if (num == 42U)
					{
						this.eCBFBBNGNPM_.AddEntriesFrom(ref input, SyncRogueHandbookDataUpdateScNotify._repeated_eCBFBBNGNPM_codec);
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.jJPHKACOFHP_.AddEntriesFrom(ref input, SyncRogueHandbookDataUpdateScNotify._repeated_jJPHKACOFHP_codec);
						continue;
					}
					if (num == 90U)
					{
						this.pPIMHAIDMII_.AddEntriesFrom(ref input, SyncRogueHandbookDataUpdateScNotify._repeated_pPIMHAIDMII_codec);
						continue;
					}
					if (num == 114U)
					{
						this.nNLPKGJLNHD_.AddEntriesFrom(ref input, SyncRogueHandbookDataUpdateScNotify._repeated_nNLPKGJLNHD_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040054DE RID: 21726
		private static readonly MessageParser<SyncRogueHandbookDataUpdateScNotify> _parser = new MessageParser<SyncRogueHandbookDataUpdateScNotify>(() => new SyncRogueHandbookDataUpdateScNotify());

		// Token: 0x040054DF RID: 21727
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054E0 RID: 21728
		public const int NNLPKGJLNHDFieldNumber = 14;

		// Token: 0x040054E1 RID: 21729
		private static readonly FieldCodec<DMDEOGJEGPI> _repeated_nNLPKGJLNHD_codec = FieldCodec.ForMessage<DMDEOGJEGPI>(114U, DMDEOGJEGPI.Parser);

		// Token: 0x040054E2 RID: 21730
		private readonly RepeatedField<DMDEOGJEGPI> nNLPKGJLNHD_ = new RepeatedField<DMDEOGJEGPI>();

		// Token: 0x040054E3 RID: 21731
		public const int PPIMHAIDMIIFieldNumber = 11;

		// Token: 0x040054E4 RID: 21732
		private static readonly FieldCodec<RogueMagicScepterInfo> _repeated_pPIMHAIDMII_codec = FieldCodec.ForMessage<RogueMagicScepterInfo>(90U, RogueMagicScepterInfo.Parser);

		// Token: 0x040054E5 RID: 21733
		private readonly RepeatedField<RogueMagicScepterInfo> pPIMHAIDMII_ = new RepeatedField<RogueMagicScepterInfo>();

		// Token: 0x040054E6 RID: 21734
		public const int ECBFBBNGNPMFieldNumber = 5;

		// Token: 0x040054E7 RID: 21735
		private static readonly FieldCodec<BFDCJNAGBCH> _repeated_eCBFBBNGNPM_codec = FieldCodec.ForMessage<BFDCJNAGBCH>(42U, BFDCJNAGBCH.Parser);

		// Token: 0x040054E8 RID: 21736
		private readonly RepeatedField<BFDCJNAGBCH> eCBFBBNGNPM_ = new RepeatedField<BFDCJNAGBCH>();

		// Token: 0x040054E9 RID: 21737
		public const int JJPHKACOFHPFieldNumber = 10;

		// Token: 0x040054EA RID: 21738
		private static readonly FieldCodec<RogueMagicUnitInfo> _repeated_jJPHKACOFHP_codec = FieldCodec.ForMessage<RogueMagicUnitInfo>(82U, RogueMagicUnitInfo.Parser);

		// Token: 0x040054EB RID: 21739
		private readonly RepeatedField<RogueMagicUnitInfo> jJPHKACOFHP_ = new RepeatedField<RogueMagicUnitInfo>();

		// Token: 0x040054EC RID: 21740
		public const int JDGHMMCMPJHFieldNumber = 1;

		// Token: 0x040054ED RID: 21741
		private static readonly FieldCodec<RogueHandbookMazeBuff> _repeated_jDGHMMCMPJH_codec = FieldCodec.ForMessage<RogueHandbookMazeBuff>(10U, RogueHandbookMazeBuff.Parser);

		// Token: 0x040054EE RID: 21742
		private readonly RepeatedField<RogueHandbookMazeBuff> jDGHMMCMPJH_ = new RepeatedField<RogueHandbookMazeBuff>();
	}
}
