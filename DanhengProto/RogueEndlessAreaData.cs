using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E79 RID: 3705
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueEndlessAreaData : IMessage<RogueEndlessAreaData>, IMessage, IEquatable<RogueEndlessAreaData>, IDeepCloneable<RogueEndlessAreaData>, IBufferMessage
	{
		// Token: 0x17002EA4 RID: 11940
		// (get) Token: 0x0600A548 RID: 42312 RVA: 0x001BC33F File Offset: 0x001BA53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueEndlessAreaData> Parser
		{
			get
			{
				return RogueEndlessAreaData._parser;
			}
		}

		// Token: 0x17002EA5 RID: 11941
		// (get) Token: 0x0600A549 RID: 42313 RVA: 0x001BC346 File Offset: 0x001BA546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueEndlessAreaDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x0600A54A RID: 42314 RVA: 0x001BC358 File Offset: 0x001BA558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueEndlessAreaData.Descriptor;
			}
		}

		// Token: 0x0600A54B RID: 42315 RVA: 0x001BC35F File Offset: 0x001BA55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAreaData()
		{
		}

		// Token: 0x0600A54C RID: 42316 RVA: 0x001BC368 File Offset: 0x001BA568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAreaData(RogueEndlessAreaData other) : this()
		{
			this.panelId_ = other.panelId_;
			this.areaId_ = other.areaId_;
			this.nGEFPCEEMEF_ = ((other.nGEFPCEEMEF_ != null) ? other.nGEFPCEEMEF_.Clone() : null);
			this.hCMHGKIJKFI_ = ((other.hCMHGKIJKFI_ != null) ? other.hCMHGKIJKFI_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A54D RID: 42317 RVA: 0x001BC3DC File Offset: 0x001BA5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessAreaData Clone()
		{
			return new RogueEndlessAreaData(this);
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x0600A54E RID: 42318 RVA: 0x001BC3E4 File Offset: 0x001BA5E4
		// (set) Token: 0x0600A54F RID: 42319 RVA: 0x001BC3EC File Offset: 0x001BA5EC
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

		// Token: 0x17002EA8 RID: 11944
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x001BC3F5 File Offset: 0x001BA5F5
		// (set) Token: 0x0600A551 RID: 42321 RVA: 0x001BC3FD File Offset: 0x001BA5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x17002EA9 RID: 11945
		// (get) Token: 0x0600A552 RID: 42322 RVA: 0x001BC406 File Offset: 0x001BA606
		// (set) Token: 0x0600A553 RID: 42323 RVA: 0x001BC40E File Offset: 0x001BA60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNPMGACEBMM NGEFPCEEMEF
		{
			get
			{
				return this.nGEFPCEEMEF_;
			}
			set
			{
				this.nGEFPCEEMEF_ = value;
			}
		}

		// Token: 0x17002EAA RID: 11946
		// (get) Token: 0x0600A554 RID: 42324 RVA: 0x001BC417 File Offset: 0x001BA617
		// (set) Token: 0x0600A555 RID: 42325 RVA: 0x001BC41F File Offset: 0x001BA61F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueEndlessLayerInfo HCMHGKIJKFI
		{
			get
			{
				return this.hCMHGKIJKFI_;
			}
			set
			{
				this.hCMHGKIJKFI_ = value;
			}
		}

		// Token: 0x0600A556 RID: 42326 RVA: 0x001BC428 File Offset: 0x001BA628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueEndlessAreaData);
		}

		// Token: 0x0600A557 RID: 42327 RVA: 0x001BC438 File Offset: 0x001BA638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueEndlessAreaData other)
		{
			return other != null && (other == this || (this.PanelId == other.PanelId && this.AreaId == other.AreaId && object.Equals(this.NGEFPCEEMEF, other.NGEFPCEEMEF) && object.Equals(this.HCMHGKIJKFI, other.HCMHGKIJKFI) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A558 RID: 42328 RVA: 0x001BC4AC File Offset: 0x001BA6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			if (this.nGEFPCEEMEF_ != null)
			{
				num ^= this.NGEFPCEEMEF.GetHashCode();
			}
			if (this.hCMHGKIJKFI_ != null)
			{
				num ^= this.HCMHGKIJKFI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A559 RID: 42329 RVA: 0x001BC530 File Offset: 0x001BA730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A55A RID: 42330 RVA: 0x001BC538 File Offset: 0x001BA738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A55B RID: 42331 RVA: 0x001BC544 File Offset: 0x001BA744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hCMHGKIJKFI_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.HCMHGKIJKFI);
			}
			if (this.nGEFPCEEMEF_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.NGEFPCEEMEF);
			}
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AreaId);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.PanelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x001BC5D8 File Offset: 0x001BA7D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			if (this.nGEFPCEEMEF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NGEFPCEEMEF);
			}
			if (this.hCMHGKIJKFI_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HCMHGKIJKFI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x001BC660 File Offset: 0x001BA860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueEndlessAreaData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			if (other.nGEFPCEEMEF_ != null)
			{
				if (this.nGEFPCEEMEF_ == null)
				{
					this.NGEFPCEEMEF = new DNPMGACEBMM();
				}
				this.NGEFPCEEMEF.MergeFrom(other.NGEFPCEEMEF);
			}
			if (other.hCMHGKIJKFI_ != null)
			{
				if (this.hCMHGKIJKFI_ == null)
				{
					this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
				}
				this.HCMHGKIJKFI.MergeFrom(other.HCMHGKIJKFI);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x001BC708 File Offset: 0x001BA908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A55F RID: 42335 RVA: 0x001BC714 File Offset: 0x001BA914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 26U)
					{
						if (this.hCMHGKIJKFI_ == null)
						{
							this.HCMHGKIJKFI = new RogueEndlessLayerInfo();
						}
						input.ReadMessage(this.HCMHGKIJKFI);
						continue;
					}
					if (num == 42U)
					{
						if (this.nGEFPCEEMEF_ == null)
						{
							this.NGEFPCEEMEF = new DNPMGACEBMM();
						}
						input.ReadMessage(this.NGEFPCEEMEF);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400437E RID: 17278
		private static readonly MessageParser<RogueEndlessAreaData> _parser = new MessageParser<RogueEndlessAreaData>(() => new RogueEndlessAreaData());

		// Token: 0x0400437F RID: 17279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004380 RID: 17280
		public const int PanelIdFieldNumber = 7;

		// Token: 0x04004381 RID: 17281
		private uint panelId_;

		// Token: 0x04004382 RID: 17282
		public const int AreaIdFieldNumber = 6;

		// Token: 0x04004383 RID: 17283
		private uint areaId_;

		// Token: 0x04004384 RID: 17284
		public const int NGEFPCEEMEFFieldNumber = 5;

		// Token: 0x04004385 RID: 17285
		private DNPMGACEBMM nGEFPCEEMEF_;

		// Token: 0x04004386 RID: 17286
		public const int HCMHGKIJKFIFieldNumber = 3;

		// Token: 0x04004387 RID: 17287
		private RogueEndlessLayerInfo hCMHGKIJKFI_;
	}
}
