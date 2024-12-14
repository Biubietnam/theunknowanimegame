using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F5 RID: 245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicDetailInfo : IMessage<BattleRogueMagicDetailInfo>, IMessage, IEquatable<BattleRogueMagicDetailInfo>, IDeepCloneable<BattleRogueMagicDetailInfo>, IBufferMessage
	{
		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x000208E3 File Offset: 0x0001EAE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicDetailInfo> Parser
		{
			get
			{
				return BattleRogueMagicDetailInfo._parser;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000208EA File Offset: 0x0001EAEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicDetailInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AF2 RID: 2802 RVA: 0x000208FC File Offset: 0x0001EAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicDetailInfo.Descriptor;
			}
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00020903 File Offset: 0x0001EB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicDetailInfo()
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002090B File Offset: 0x0001EB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicDetailInfo(BattleRogueMagicDetailInfo other) : this()
		{
			this.battleMagicItemInfo_ = ((other.battleMagicItemInfo_ != null) ? other.battleMagicItemInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00020940 File Offset: 0x0001EB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicDetailInfo Clone()
		{
			return new BattleRogueMagicDetailInfo(this);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00020948 File Offset: 0x0001EB48
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00020950 File Offset: 0x0001EB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicItemInfo BattleMagicItemInfo
		{
			get
			{
				return this.battleMagicItemInfo_;
			}
			set
			{
				this.battleMagicItemInfo_ = value;
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00020959 File Offset: 0x0001EB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicDetailInfo);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00020967 File Offset: 0x0001EB67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicDetailInfo other)
		{
			return other != null && (other == this || (object.Equals(this.BattleMagicItemInfo, other.BattleMagicItemInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002099C File Offset: 0x0001EB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleMagicItemInfo_ != null)
			{
				num ^= this.BattleMagicItemInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x000209D8 File Offset: 0x0001EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x000209E0 File Offset: 0x0001EBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x000209E9 File Offset: 0x0001EBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleMagicItemInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BattleMagicItemInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00020A1C File Offset: 0x0001EC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleMagicItemInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleMagicItemInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00020A5C File Offset: 0x0001EC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicDetailInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleMagicItemInfo_ != null)
			{
				if (this.battleMagicItemInfo_ == null)
				{
					this.BattleMagicItemInfo = new BattleRogueMagicItemInfo();
				}
				this.BattleMagicItemInfo.MergeFrom(other.BattleMagicItemInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00020AB0 File Offset: 0x0001ECB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00020ABC File Offset: 0x0001ECBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.battleMagicItemInfo_ == null)
					{
						this.BattleMagicItemInfo = new BattleRogueMagicItemInfo();
					}
					input.ReadMessage(this.BattleMagicItemInfo);
				}
			}
		}

		// Token: 0x040004A3 RID: 1187
		private static readonly MessageParser<BattleRogueMagicDetailInfo> _parser = new MessageParser<BattleRogueMagicDetailInfo>(() => new BattleRogueMagicDetailInfo());

		// Token: 0x040004A4 RID: 1188
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004A5 RID: 1189
		public const int BattleMagicItemInfoFieldNumber = 1;

		// Token: 0x040004A6 RID: 1190
		private BattleRogueMagicItemInfo battleMagicItemInfo_;
	}
}
