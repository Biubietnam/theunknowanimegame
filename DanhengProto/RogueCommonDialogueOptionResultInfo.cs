using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E4D RID: 3661
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonDialogueOptionResultInfo : IMessage<RogueCommonDialogueOptionResultInfo>, IMessage, IEquatable<RogueCommonDialogueOptionResultInfo>, IDeepCloneable<RogueCommonDialogueOptionResultInfo>, IBufferMessage
	{
		// Token: 0x17002E23 RID: 11811
		// (get) Token: 0x0600A356 RID: 41814 RVA: 0x001B77E7 File Offset: 0x001B59E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonDialogueOptionResultInfo> Parser
		{
			get
			{
				return RogueCommonDialogueOptionResultInfo._parser;
			}
		}

		// Token: 0x17002E24 RID: 11812
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x001B77EE File Offset: 0x001B59EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionResultInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E25 RID: 11813
		// (get) Token: 0x0600A358 RID: 41816 RVA: 0x001B7800 File Offset: 0x001B5A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonDialogueOptionResultInfo.Descriptor;
			}
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x001B7807 File Offset: 0x001B5A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionResultInfo()
		{
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x001B7810 File Offset: 0x001B5A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionResultInfo(RogueCommonDialogueOptionResultInfo other) : this()
		{
			this.battleResultInfo_ = ((other.battleResultInfo_ != null) ? other.battleResultInfo_.Clone() : null);
			this.hNOKHHOAEDP_ = ((other.hNOKHHOAEDP_ != null) ? other.hNOKHHOAEDP_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x001B786C File Offset: 0x001B5A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionResultInfo Clone()
		{
			return new RogueCommonDialogueOptionResultInfo(this);
		}

		// Token: 0x17002E26 RID: 11814
		// (get) Token: 0x0600A35C RID: 41820 RVA: 0x001B7874 File Offset: 0x001B5A74
		// (set) Token: 0x0600A35D RID: 41821 RVA: 0x001B787C File Offset: 0x001B5A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionBattleResultInfo BattleResultInfo
		{
			get
			{
				return this.battleResultInfo_;
			}
			set
			{
				this.battleResultInfo_ = value;
			}
		}

		// Token: 0x17002E27 RID: 11815
		// (get) Token: 0x0600A35E RID: 41822 RVA: 0x001B7885 File Offset: 0x001B5A85
		// (set) Token: 0x0600A35F RID: 41823 RVA: 0x001B788D File Offset: 0x001B5A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKLGFMLGHIG HNOKHHOAEDP
		{
			get
			{
				return this.hNOKHHOAEDP_;
			}
			set
			{
				this.hNOKHHOAEDP_ = value;
			}
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x001B7896 File Offset: 0x001B5A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonDialogueOptionResultInfo);
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x001B78A4 File Offset: 0x001B5AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonDialogueOptionResultInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BattleResultInfo, other.BattleResultInfo) && object.Equals(this.HNOKHHOAEDP, other.HNOKHHOAEDP) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x001B78F8 File Offset: 0x001B5AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleResultInfo_ != null)
			{
				num ^= this.BattleResultInfo.GetHashCode();
			}
			if (this.hNOKHHOAEDP_ != null)
			{
				num ^= this.HNOKHHOAEDP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x001B794A File Offset: 0x001B5B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x001B7952 File Offset: 0x001B5B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x001B795C File Offset: 0x001B5B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.hNOKHHOAEDP_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.HNOKHHOAEDP);
			}
			if (this.battleResultInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BattleResultInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x001B79B8 File Offset: 0x001B5BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleResultInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleResultInfo);
			}
			if (this.hNOKHHOAEDP_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HNOKHHOAEDP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x001B7A10 File Offset: 0x001B5C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonDialogueOptionResultInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleResultInfo_ != null)
			{
				if (this.battleResultInfo_ == null)
				{
					this.BattleResultInfo = new RogueCommonDialogueOptionBattleResultInfo();
				}
				this.BattleResultInfo.MergeFrom(other.BattleResultInfo);
			}
			if (other.hNOKHHOAEDP_ != null)
			{
				if (this.hNOKHHOAEDP_ == null)
				{
					this.HNOKHHOAEDP = new KKLGFMLGHIG();
				}
				this.HNOKHHOAEDP.MergeFrom(other.HNOKHHOAEDP);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x001B7A90 File Offset: 0x001B5C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x001B7A9C File Offset: 0x001B5C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.battleResultInfo_ == null)
						{
							this.BattleResultInfo = new RogueCommonDialogueOptionBattleResultInfo();
						}
						input.ReadMessage(this.BattleResultInfo);
					}
				}
				else
				{
					if (this.hNOKHHOAEDP_ == null)
					{
						this.HNOKHHOAEDP = new KKLGFMLGHIG();
					}
					input.ReadMessage(this.HNOKHHOAEDP);
				}
			}
		}

		// Token: 0x040042E8 RID: 17128
		private static readonly MessageParser<RogueCommonDialogueOptionResultInfo> _parser = new MessageParser<RogueCommonDialogueOptionResultInfo>(() => new RogueCommonDialogueOptionResultInfo());

		// Token: 0x040042E9 RID: 17129
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042EA RID: 17130
		public const int BattleResultInfoFieldNumber = 15;

		// Token: 0x040042EB RID: 17131
		private RogueCommonDialogueOptionBattleResultInfo battleResultInfo_;

		// Token: 0x040042EC RID: 17132
		public const int HNOKHHOAEDPFieldNumber = 9;

		// Token: 0x040042ED RID: 17133
		private KKLGFMLGHIG hNOKHHOAEDP_;
	}
}
