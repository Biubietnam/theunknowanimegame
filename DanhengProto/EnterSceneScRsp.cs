using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000465 RID: 1125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSceneScRsp : IMessage<EnterSceneScRsp>, IMessage, IEquatable<EnterSceneScRsp>, IDeepCloneable<EnterSceneScRsp>, IBufferMessage
	{
		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003212 RID: 12818 RVA: 0x00089E23 File Offset: 0x00088023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSceneScRsp> Parser
		{
			get
			{
				return EnterSceneScRsp._parser;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x00089E2A File Offset: 0x0008802A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x00089E3C File Offset: 0x0008803C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSceneScRsp.Descriptor;
			}
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00089E43 File Offset: 0x00088043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneScRsp()
		{
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00089E4C File Offset: 0x0008804C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneScRsp(EnterSceneScRsp other) : this()
		{
			this.contentId_ = other.contentId_;
			this.gameStoryLineId_ = other.gameStoryLineId_;
			this.isOverMap_ = other.isOverMap_;
			this.isCloseMap_ = other.isCloseMap_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00089EAC File Offset: 0x000880AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSceneScRsp Clone()
		{
			return new EnterSceneScRsp(this);
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003218 RID: 12824 RVA: 0x00089EB4 File Offset: 0x000880B4
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x00089EBC File Offset: 0x000880BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ContentId
		{
			get
			{
				return this.contentId_;
			}
			set
			{
				this.contentId_ = value;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x0600321A RID: 12826 RVA: 0x00089EC5 File Offset: 0x000880C5
		// (set) Token: 0x0600321B RID: 12827 RVA: 0x00089ECD File Offset: 0x000880CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStoryLineId
		{
			get
			{
				return this.gameStoryLineId_;
			}
			set
			{
				this.gameStoryLineId_ = value;
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600321C RID: 12828 RVA: 0x00089ED6 File Offset: 0x000880D6
		// (set) Token: 0x0600321D RID: 12829 RVA: 0x00089EDE File Offset: 0x000880DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOverMap
		{
			get
			{
				return this.isOverMap_;
			}
			set
			{
				this.isOverMap_ = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600321E RID: 12830 RVA: 0x00089EE7 File Offset: 0x000880E7
		// (set) Token: 0x0600321F RID: 12831 RVA: 0x00089EEF File Offset: 0x000880EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCloseMap
		{
			get
			{
				return this.isCloseMap_;
			}
			set
			{
				this.isCloseMap_ = value;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x00089EF8 File Offset: 0x000880F8
		// (set) Token: 0x06003221 RID: 12833 RVA: 0x00089F00 File Offset: 0x00088100
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

		// Token: 0x06003222 RID: 12834 RVA: 0x00089F09 File Offset: 0x00088109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSceneScRsp);
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00089F18 File Offset: 0x00088118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSceneScRsp other)
		{
			return other != null && (other == this || (this.ContentId == other.ContentId && this.GameStoryLineId == other.GameStoryLineId && this.IsOverMap == other.IsOverMap && this.IsCloseMap == other.IsCloseMap && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00089F94 File Offset: 0x00088194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ContentId != 0U)
			{
				num ^= this.ContentId.GetHashCode();
			}
			if (this.GameStoryLineId != 0U)
			{
				num ^= this.GameStoryLineId.GetHashCode();
			}
			if (this.IsOverMap)
			{
				num ^= this.IsOverMap.GetHashCode();
			}
			if (this.IsCloseMap)
			{
				num ^= this.IsCloseMap.GetHashCode();
			}
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

		// Token: 0x06003225 RID: 12837 RVA: 0x0008A037 File Offset: 0x00088237
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0008A03F File Offset: 0x0008823F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x0008A048 File Offset: 0x00088248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ContentId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ContentId);
			}
			if (this.GameStoryLineId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GameStoryLineId);
			}
			if (this.IsOverMap)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsOverMap);
			}
			if (this.IsCloseMap)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsCloseMap);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x0008A0F4 File Offset: 0x000882F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ContentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ContentId);
			}
			if (this.GameStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStoryLineId);
			}
			if (this.IsOverMap)
			{
				num += 2;
			}
			if (this.IsCloseMap)
			{
				num += 2;
			}
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

		// Token: 0x06003229 RID: 12841 RVA: 0x0008A17C File Offset: 0x0008837C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSceneScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ContentId != 0U)
			{
				this.ContentId = other.ContentId;
			}
			if (other.GameStoryLineId != 0U)
			{
				this.GameStoryLineId = other.GameStoryLineId;
			}
			if (other.IsOverMap)
			{
				this.IsOverMap = other.IsOverMap;
			}
			if (other.IsCloseMap)
			{
				this.IsCloseMap = other.IsCloseMap;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0008A208 File Offset: 0x00088408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0008A214 File Offset: 0x00088414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ContentId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.GameStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IsOverMap = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.IsCloseMap = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040013F6 RID: 5110
		private static readonly MessageParser<EnterSceneScRsp> _parser = new MessageParser<EnterSceneScRsp>(() => new EnterSceneScRsp());

		// Token: 0x040013F7 RID: 5111
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013F8 RID: 5112
		public const int ContentIdFieldNumber = 7;

		// Token: 0x040013F9 RID: 5113
		private uint contentId_;

		// Token: 0x040013FA RID: 5114
		public const int GameStoryLineIdFieldNumber = 8;

		// Token: 0x040013FB RID: 5115
		private uint gameStoryLineId_;

		// Token: 0x040013FC RID: 5116
		public const int IsOverMapFieldNumber = 10;

		// Token: 0x040013FD RID: 5117
		private bool isOverMap_;

		// Token: 0x040013FE RID: 5118
		public const int IsCloseMapFieldNumber = 12;

		// Token: 0x040013FF RID: 5119
		private bool isCloseMap_;

		// Token: 0x04001400 RID: 5120
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001401 RID: 5121
		private uint retcode_;
	}
}
