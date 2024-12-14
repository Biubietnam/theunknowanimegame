using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D23 RID: 3363
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordBattleResultScNotify : IMessage<PunkLordBattleResultScNotify>, IMessage, IEquatable<PunkLordBattleResultScNotify>, IDeepCloneable<PunkLordBattleResultScNotify>, IBufferMessage
	{
		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x06009631 RID: 38449 RVA: 0x0018F75F File Offset: 0x0018D95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordBattleResultScNotify> Parser
		{
			get
			{
				return PunkLordBattleResultScNotify._parser;
			}
		}

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x06009632 RID: 38450 RVA: 0x0018F766 File Offset: 0x0018D966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleResultScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x06009633 RID: 38451 RVA: 0x0018F778 File Offset: 0x0018D978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordBattleResultScNotify.Descriptor;
			}
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x0018F77F File Offset: 0x0018D97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleResultScNotify()
		{
		}

		// Token: 0x06009635 RID: 38453 RVA: 0x0018F788 File Offset: 0x0018D988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleResultScNotify(PunkLordBattleResultScNotify other) : this()
		{
			this.cDAJGLIIBII_ = ((other.cDAJGLIIBII_ != null) ? other.cDAJGLIIBII_.Clone() : null);
			this.jHGANKBJGCG_ = other.jHGANKBJGCG_;
			this.gPIPJMPLECH_ = other.gPIPJMPLECH_;
			this.iOEBEBCENHO_ = ((other.iOEBEBCENHO_ != null) ? other.iOEBEBCENHO_.Clone() : null);
			this.gOCJFIAEMKB_ = other.gOCJFIAEMKB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009636 RID: 38454 RVA: 0x0018F808 File Offset: 0x0018DA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleResultScNotify Clone()
		{
			return new PunkLordBattleResultScNotify(this);
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x06009637 RID: 38455 RVA: 0x0018F810 File Offset: 0x0018DA10
		// (set) Token: 0x06009638 RID: 38456 RVA: 0x0018F818 File Offset: 0x0018DA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecord CDAJGLIIBII
		{
			get
			{
				return this.cDAJGLIIBII_;
			}
			set
			{
				this.cDAJGLIIBII_ = value;
			}
		}

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x06009639 RID: 38457 RVA: 0x0018F821 File Offset: 0x0018DA21
		// (set) Token: 0x0600963A RID: 38458 RVA: 0x0018F829 File Offset: 0x0018DA29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JHGANKBJGCG
		{
			get
			{
				return this.jHGANKBJGCG_;
			}
			set
			{
				this.jHGANKBJGCG_ = value;
			}
		}

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600963B RID: 38459 RVA: 0x0018F832 File Offset: 0x0018DA32
		// (set) Token: 0x0600963C RID: 38460 RVA: 0x0018F83A File Offset: 0x0018DA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPIPJMPLECH
		{
			get
			{
				return this.gPIPJMPLECH_;
			}
			set
			{
				this.gPIPJMPLECH_ = value;
			}
		}

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600963D RID: 38461 RVA: 0x0018F843 File Offset: 0x0018DA43
		// (set) Token: 0x0600963E RID: 38462 RVA: 0x0018F84B File Offset: 0x0018DA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo IOEBEBCENHO
		{
			get
			{
				return this.iOEBEBCENHO_;
			}
			set
			{
				this.iOEBEBCENHO_ = value;
			}
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600963F RID: 38463 RVA: 0x0018F854 File Offset: 0x0018DA54
		// (set) Token: 0x06009640 RID: 38464 RVA: 0x0018F85C File Offset: 0x0018DA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GOCJFIAEMKB
		{
			get
			{
				return this.gOCJFIAEMKB_;
			}
			set
			{
				this.gOCJFIAEMKB_ = value;
			}
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x0018F865 File Offset: 0x0018DA65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordBattleResultScNotify);
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0018F874 File Offset: 0x0018DA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordBattleResultScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CDAJGLIIBII, other.CDAJGLIIBII) && this.JHGANKBJGCG == other.JHGANKBJGCG && this.GPIPJMPLECH == other.GPIPJMPLECH && object.Equals(this.IOEBEBCENHO, other.IOEBEBCENHO) && this.GOCJFIAEMKB == other.GOCJFIAEMKB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0018F8F8 File Offset: 0x0018DAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cDAJGLIIBII_ != null)
			{
				num ^= this.CDAJGLIIBII.GetHashCode();
			}
			if (this.JHGANKBJGCG != 0U)
			{
				num ^= this.JHGANKBJGCG.GetHashCode();
			}
			if (this.GPIPJMPLECH != 0U)
			{
				num ^= this.GPIPJMPLECH.GetHashCode();
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num ^= this.IOEBEBCENHO.GetHashCode();
			}
			if (this.GOCJFIAEMKB != 0U)
			{
				num ^= this.GOCJFIAEMKB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009644 RID: 38468 RVA: 0x0018F995 File Offset: 0x0018DB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009645 RID: 38469 RVA: 0x0018F99D File Offset: 0x0018DB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009646 RID: 38470 RVA: 0x0018F9A8 File Offset: 0x0018DBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iOEBEBCENHO_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.IOEBEBCENHO);
			}
			if (this.JHGANKBJGCG != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.JHGANKBJGCG);
			}
			if (this.GPIPJMPLECH != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GPIPJMPLECH);
			}
			if (this.GOCJFIAEMKB != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.GOCJFIAEMKB);
			}
			if (this.cDAJGLIIBII_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.CDAJGLIIBII);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009647 RID: 38471 RVA: 0x0018FA58 File Offset: 0x0018DC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cDAJGLIIBII_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CDAJGLIIBII);
			}
			if (this.JHGANKBJGCG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JHGANKBJGCG);
			}
			if (this.GPIPJMPLECH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPIPJMPLECH);
			}
			if (this.iOEBEBCENHO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IOEBEBCENHO);
			}
			if (this.GOCJFIAEMKB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GOCJFIAEMKB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009648 RID: 38472 RVA: 0x0018FAF8 File Offset: 0x0018DCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordBattleResultScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cDAJGLIIBII_ != null)
			{
				if (this.cDAJGLIIBII_ == null)
				{
					this.CDAJGLIIBII = new PunkLordBattleRecord();
				}
				this.CDAJGLIIBII.MergeFrom(other.CDAJGLIIBII);
			}
			if (other.JHGANKBJGCG != 0U)
			{
				this.JHGANKBJGCG = other.JHGANKBJGCG;
			}
			if (other.GPIPJMPLECH != 0U)
			{
				this.GPIPJMPLECH = other.GPIPJMPLECH;
			}
			if (other.iOEBEBCENHO_ != null)
			{
				if (this.iOEBEBCENHO_ == null)
				{
					this.IOEBEBCENHO = new PunkLordMonsterBasicInfo();
				}
				this.IOEBEBCENHO.MergeFrom(other.IOEBEBCENHO);
			}
			if (other.GOCJFIAEMKB != 0U)
			{
				this.GOCJFIAEMKB = other.GOCJFIAEMKB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009649 RID: 38473 RVA: 0x0018FBB4 File Offset: 0x0018DDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600964A RID: 38474 RVA: 0x0018FBC0 File Offset: 0x0018DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 10U)
					{
						if (this.iOEBEBCENHO_ == null)
						{
							this.IOEBEBCENHO = new PunkLordMonsterBasicInfo();
						}
						input.ReadMessage(this.IOEBEBCENHO);
						continue;
					}
					if (num == 48U)
					{
						this.JHGANKBJGCG = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.GPIPJMPLECH = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.GOCJFIAEMKB = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.cDAJGLIIBII_ == null)
						{
							this.CDAJGLIIBII = new PunkLordBattleRecord();
						}
						input.ReadMessage(this.CDAJGLIIBII);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003A3E RID: 14910
		private static readonly MessageParser<PunkLordBattleResultScNotify> _parser = new MessageParser<PunkLordBattleResultScNotify>(() => new PunkLordBattleResultScNotify());

		// Token: 0x04003A3F RID: 14911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A40 RID: 14912
		public const int CDAJGLIIBIIFieldNumber = 14;

		// Token: 0x04003A41 RID: 14913
		private PunkLordBattleRecord cDAJGLIIBII_;

		// Token: 0x04003A42 RID: 14914
		public const int JHGANKBJGCGFieldNumber = 6;

		// Token: 0x04003A43 RID: 14915
		private uint jHGANKBJGCG_;

		// Token: 0x04003A44 RID: 14916
		public const int GPIPJMPLECHFieldNumber = 9;

		// Token: 0x04003A45 RID: 14917
		private uint gPIPJMPLECH_;

		// Token: 0x04003A46 RID: 14918
		public const int IOEBEBCENHOFieldNumber = 1;

		// Token: 0x04003A47 RID: 14919
		private PunkLordMonsterBasicInfo iOEBEBCENHO_;

		// Token: 0x04003A48 RID: 14920
		public const int GOCJFIAEMKBFieldNumber = 12;

		// Token: 0x04003A49 RID: 14921
		private uint gOCJFIAEMKB_;
	}
}
