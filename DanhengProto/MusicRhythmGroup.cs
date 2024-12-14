using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BE1 RID: 3041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmGroup : IMessage<MusicRhythmGroup>, IMessage, IEquatable<MusicRhythmGroup>, IDeepCloneable<MusicRhythmGroup>, IBufferMessage
	{
		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06008698 RID: 34456 RVA: 0x00163499 File Offset: 0x00161699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmGroup> Parser
		{
			get
			{
				return MusicRhythmGroup._parser;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06008699 RID: 34457 RVA: 0x001634A0 File Offset: 0x001616A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmGroupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x0600869A RID: 34458 RVA: 0x001634B2 File Offset: 0x001616B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmGroup.Descriptor;
			}
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x001634B9 File Offset: 0x001616B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmGroup()
		{
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x001634D8 File Offset: 0x001616D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmGroup(MusicRhythmGroup other) : this()
		{
			this.musicGroupPhase_ = other.musicGroupPhase_;
			this.mPCFOJALNHN_ = other.mPCFOJALNHN_.Clone();
			this.oALLJLKBIOJ_ = other.oALLJLKBIOJ_.Clone();
			this.musicGroupId_ = other.musicGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00163536 File Offset: 0x00161736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmGroup Clone()
		{
			return new MusicRhythmGroup(this);
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x0600869E RID: 34462 RVA: 0x0016353E File Offset: 0x0016173E
		// (set) Token: 0x0600869F RID: 34463 RVA: 0x00163546 File Offset: 0x00161746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MusicGroupPhase
		{
			get
			{
				return this.musicGroupPhase_;
			}
			set
			{
				this.musicGroupPhase_ = value;
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x060086A0 RID: 34464 RVA: 0x0016354F File Offset: 0x0016174F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MPCFOJALNHN
		{
			get
			{
				return this.mPCFOJALNHN_;
			}
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x060086A1 RID: 34465 RVA: 0x00163557 File Offset: 0x00161757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> OALLJLKBIOJ
		{
			get
			{
				return this.oALLJLKBIOJ_;
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x060086A2 RID: 34466 RVA: 0x0016355F File Offset: 0x0016175F
		// (set) Token: 0x060086A3 RID: 34467 RVA: 0x00163567 File Offset: 0x00161767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MusicGroupId
		{
			get
			{
				return this.musicGroupId_;
			}
			set
			{
				this.musicGroupId_ = value;
			}
		}

		// Token: 0x060086A4 RID: 34468 RVA: 0x00163570 File Offset: 0x00161770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmGroup);
		}

		// Token: 0x060086A5 RID: 34469 RVA: 0x00163580 File Offset: 0x00161780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmGroup other)
		{
			return other != null && (other == this || (this.MusicGroupPhase == other.MusicGroupPhase && this.mPCFOJALNHN_.Equals(other.mPCFOJALNHN_) && this.oALLJLKBIOJ_.Equals(other.oALLJLKBIOJ_) && this.MusicGroupId == other.MusicGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086A6 RID: 34470 RVA: 0x001635F4 File Offset: 0x001617F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MusicGroupPhase != 0U)
			{
				num ^= this.MusicGroupPhase.GetHashCode();
			}
			num ^= this.mPCFOJALNHN_.GetHashCode();
			num ^= this.oALLJLKBIOJ_.GetHashCode();
			if (this.MusicGroupId != 0U)
			{
				num ^= this.MusicGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060086A7 RID: 34471 RVA: 0x00163668 File Offset: 0x00161868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x00163670 File Offset: 0x00161870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x0016367C File Offset: 0x0016187C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mPCFOJALNHN_.WriteTo(ref output, MusicRhythmGroup._repeated_mPCFOJALNHN_codec);
			if (this.MusicGroupId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.MusicGroupId);
			}
			this.oALLJLKBIOJ_.WriteTo(ref output, MusicRhythmGroup._repeated_oALLJLKBIOJ_codec);
			if (this.MusicGroupPhase != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.MusicGroupPhase);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x001636F8 File Offset: 0x001618F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MusicGroupPhase != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MusicGroupPhase);
			}
			num += this.mPCFOJALNHN_.CalculateSize(MusicRhythmGroup._repeated_mPCFOJALNHN_codec);
			num += this.oALLJLKBIOJ_.CalculateSize(MusicRhythmGroup._repeated_oALLJLKBIOJ_codec);
			if (this.MusicGroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MusicGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x00163774 File Offset: 0x00161974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmGroup other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MusicGroupPhase != 0U)
			{
				this.MusicGroupPhase = other.MusicGroupPhase;
			}
			this.mPCFOJALNHN_.Add(other.mPCFOJALNHN_);
			this.oALLJLKBIOJ_.Add(other.oALLJLKBIOJ_);
			if (other.MusicGroupId != 0U)
			{
				this.MusicGroupId = other.MusicGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x001637E6 File Offset: 0x001619E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x001637F0 File Offset: 0x001619F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 24U || num == 26U)
					{
						this.mPCFOJALNHN_.AddEntriesFrom(ref input, MusicRhythmGroup._repeated_mPCFOJALNHN_codec);
						continue;
					}
					if (num == 40U)
					{
						this.MusicGroupId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U || num == 50U)
					{
						this.oALLJLKBIOJ_.AddEntriesFrom(ref input, MusicRhythmGroup._repeated_oALLJLKBIOJ_codec);
						continue;
					}
					if (num == 80U)
					{
						this.MusicGroupPhase = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003391 RID: 13201
		private static readonly MessageParser<MusicRhythmGroup> _parser = new MessageParser<MusicRhythmGroup>(() => new MusicRhythmGroup());

		// Token: 0x04003392 RID: 13202
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003393 RID: 13203
		public const int MusicGroupPhaseFieldNumber = 10;

		// Token: 0x04003394 RID: 13204
		private uint musicGroupPhase_;

		// Token: 0x04003395 RID: 13205
		public const int MPCFOJALNHNFieldNumber = 3;

		// Token: 0x04003396 RID: 13206
		private static readonly FieldCodec<uint> _repeated_mPCFOJALNHN_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04003397 RID: 13207
		private readonly RepeatedField<uint> mPCFOJALNHN_ = new RepeatedField<uint>();

		// Token: 0x04003398 RID: 13208
		public const int OALLJLKBIOJFieldNumber = 6;

		// Token: 0x04003399 RID: 13209
		private static readonly FieldCodec<uint> _repeated_oALLJLKBIOJ_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x0400339A RID: 13210
		private readonly RepeatedField<uint> oALLJLKBIOJ_ = new RepeatedField<uint>();

		// Token: 0x0400339B RID: 13211
		public const int MusicGroupIdFieldNumber = 5;

		// Token: 0x0400339C RID: 13212
		private uint musicGroupId_;
	}
}
