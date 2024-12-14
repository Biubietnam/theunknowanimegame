using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000127 RID: 295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BJLCIEAOMLP : IMessage<BJLCIEAOMLP>, IMessage, IEquatable<BJLCIEAOMLP>, IDeepCloneable<BJLCIEAOMLP>, IBufferMessage
	{
		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00027EE8 File Offset: 0x000260E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BJLCIEAOMLP> Parser
		{
			get
			{
				return BJLCIEAOMLP._parser;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00027EEF File Offset: 0x000260EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BJLCIEAOMLPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00027F01 File Offset: 0x00026101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BJLCIEAOMLP.Descriptor;
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00027F08 File Offset: 0x00026108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJLCIEAOMLP()
		{
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00027F1C File Offset: 0x0002611C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJLCIEAOMLP(BJLCIEAOMLP other) : this()
		{
			this.aCPLFDCNGKO_ = other.aCPLFDCNGKO_;
			this.panelId_ = other.panelId_;
			this.oHFIHGBCAJA_ = other.oHFIHGBCAJA_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00027F69 File Offset: 0x00026169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BJLCIEAOMLP Clone()
		{
			return new BJLCIEAOMLP(this);
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00027F71 File Offset: 0x00026171
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00027F79 File Offset: 0x00026179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACPLFDCNGKO
		{
			get
			{
				return this.aCPLFDCNGKO_;
			}
			set
			{
				this.aCPLFDCNGKO_ = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00027F82 File Offset: 0x00026182
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00027F8A File Offset: 0x0002618A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00027F93 File Offset: 0x00026193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, KKCABEAAPJC> OHFIHGBCAJA
		{
			get
			{
				return this.oHFIHGBCAJA_;
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00027F9B File Offset: 0x0002619B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BJLCIEAOMLP);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00027FAC File Offset: 0x000261AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BJLCIEAOMLP other)
		{
			return other != null && (other == this || (this.ACPLFDCNGKO == other.ACPLFDCNGKO && this.PanelId == other.PanelId && this.OHFIHGBCAJA.Equals(other.OHFIHGBCAJA) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0002800C File Offset: 0x0002620C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ACPLFDCNGKO != 0U)
			{
				num ^= this.ACPLFDCNGKO.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			num ^= this.OHFIHGBCAJA.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00028072 File Offset: 0x00026272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0002807A File Offset: 0x0002627A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00028084 File Offset: 0x00026284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ACPLFDCNGKO != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ACPLFDCNGKO);
			}
			this.oHFIHGBCAJA_.WriteTo(ref output, BJLCIEAOMLP._map_oHFIHGBCAJA_codec);
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.PanelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000280F0 File Offset: 0x000262F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ACPLFDCNGKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACPLFDCNGKO);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			num += this.oHFIHGBCAJA_.CalculateSize(BJLCIEAOMLP._map_oHFIHGBCAJA_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0002815C File Offset: 0x0002635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BJLCIEAOMLP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ACPLFDCNGKO != 0U)
			{
				this.ACPLFDCNGKO = other.ACPLFDCNGKO;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			this.oHFIHGBCAJA_.MergeFrom(other.oHFIHGBCAJA_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000281BD File Offset: 0x000263BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000281C8 File Offset: 0x000263C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 82U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PanelId = input.ReadUInt32();
						}
					}
					else
					{
						this.oHFIHGBCAJA_.AddEntriesFrom(ref input, BJLCIEAOMLP._map_oHFIHGBCAJA_codec);
					}
				}
				else
				{
					this.ACPLFDCNGKO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040005C6 RID: 1478
		private static readonly MessageParser<BJLCIEAOMLP> _parser = new MessageParser<BJLCIEAOMLP>(() => new BJLCIEAOMLP());

		// Token: 0x040005C7 RID: 1479
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005C8 RID: 1480
		public const int ACPLFDCNGKOFieldNumber = 6;

		// Token: 0x040005C9 RID: 1481
		private uint aCPLFDCNGKO_;

		// Token: 0x040005CA RID: 1482
		public const int PanelIdFieldNumber = 11;

		// Token: 0x040005CB RID: 1483
		private uint panelId_;

		// Token: 0x040005CC RID: 1484
		public const int OHFIHGBCAJAFieldNumber = 10;

		// Token: 0x040005CD RID: 1485
		private static readonly MapField<uint, KKCABEAAPJC>.Codec _map_oHFIHGBCAJA_codec = new MapField<uint, KKCABEAAPJC>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForMessage<KKCABEAAPJC>(18U, KKCABEAAPJC.Parser), 82U);

		// Token: 0x040005CE RID: 1486
		private readonly MapField<uint, KKCABEAAPJC> oHFIHGBCAJA_ = new MapField<uint, KKCABEAAPJC>();
	}
}
