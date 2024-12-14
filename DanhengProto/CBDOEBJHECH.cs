using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200016D RID: 365
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CBDOEBJHECH : IMessage<CBDOEBJHECH>, IMessage, IEquatable<CBDOEBJHECH>, IDeepCloneable<CBDOEBJHECH>, IBufferMessage
	{
		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0002F0F7 File Offset: 0x0002D2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CBDOEBJHECH> Parser
		{
			get
			{
				return CBDOEBJHECH._parser;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x0002F0FE File Offset: 0x0002D2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CBDOEBJHECHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0002F110 File Offset: 0x0002D310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CBDOEBJHECH.Descriptor;
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0002F117 File Offset: 0x0002D317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH()
		{
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0002F12A File Offset: 0x0002D32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH(CBDOEBJHECH other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.selectMagicUnits_ = other.selectMagicUnits_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0002F160 File Offset: 0x0002D360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CBDOEBJHECH Clone()
		{
			return new CBDOEBJHECH(this);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0002F168 File Offset: 0x0002D368
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0002F170 File Offset: 0x0002D370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0002F179 File Offset: 0x0002D379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnitInfo> SelectMagicUnits
		{
			get
			{
				return this.selectMagicUnits_;
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0002F181 File Offset: 0x0002D381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CBDOEBJHECH);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0002F190 File Offset: 0x0002D390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CBDOEBJHECH other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.selectMagicUnits_.Equals(other.selectMagicUnits_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.selectMagicUnits_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002F22D File Offset: 0x0002D42D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002F235 File Offset: 0x0002D435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0002F240 File Offset: 0x0002D440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SelectHintId);
			}
			this.selectMagicUnits_.WriteTo(ref output, CBDOEBJHECH._repeated_selectMagicUnits_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0002F290 File Offset: 0x0002D490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.selectMagicUnits_.CalculateSize(CBDOEBJHECH._repeated_selectMagicUnits_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CBDOEBJHECH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.selectMagicUnits_.Add(other.selectMagicUnits_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0002F331 File Offset: 0x0002D531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002F33C File Offset: 0x0002D53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.selectMagicUnits_.AddEntriesFrom(ref input, CBDOEBJHECH._repeated_selectMagicUnits_codec);
					}
				}
				else
				{
					this.SelectHintId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040006D6 RID: 1750
		private static readonly MessageParser<CBDOEBJHECH> _parser = new MessageParser<CBDOEBJHECH>(() => new CBDOEBJHECH());

		// Token: 0x040006D7 RID: 1751
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006D8 RID: 1752
		public const int SelectHintIdFieldNumber = 10;

		// Token: 0x040006D9 RID: 1753
		private uint selectHintId_;

		// Token: 0x040006DA RID: 1754
		public const int SelectMagicUnitsFieldNumber = 11;

		// Token: 0x040006DB RID: 1755
		private static readonly FieldCodec<RogueMagicGameUnitInfo> _repeated_selectMagicUnits_codec = FieldCodec.ForMessage<RogueMagicGameUnitInfo>(90U, RogueMagicGameUnitInfo.Parser);

		// Token: 0x040006DC RID: 1756
		private readonly RepeatedField<RogueMagicGameUnitInfo> selectMagicUnits_ = new RepeatedField<RogueMagicGameUnitInfo>();
	}
}
