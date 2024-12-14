using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002AF RID: 687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateDiceInfoScNotify : IMessage<ChessRogueUpdateDiceInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateDiceInfoScNotify>, IDeepCloneable<ChessRogueUpdateDiceInfoScNotify>, IBufferMessage
	{
		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00057EAB File Offset: 0x000560AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateDiceInfoScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateDiceInfoScNotify._parser;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00057EB2 File Offset: 0x000560B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateDiceInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00057EC4 File Offset: 0x000560C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateDiceInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00057ECB File Offset: 0x000560CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDiceInfoScNotify()
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00057ED3 File Offset: 0x000560D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDiceInfoScNotify(ChessRogueUpdateDiceInfoScNotify other) : this()
		{
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00057F08 File Offset: 0x00056108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateDiceInfoScNotify Clone()
		{
			return new ChessRogueUpdateDiceInfoScNotify(this);
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x00057F10 File Offset: 0x00056110
		// (set) Token: 0x06001EBA RID: 7866 RVA: 0x00057F18 File Offset: 0x00056118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo RogueDiceInfo
		{
			get
			{
				return this.rogueDiceInfo_;
			}
			set
			{
				this.rogueDiceInfo_ = value;
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00057F21 File Offset: 0x00056121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateDiceInfoScNotify);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00057F2F File Offset: 0x0005612F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateDiceInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00057F64 File Offset: 0x00056164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00057FA0 File Offset: 0x000561A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00057FA8 File Offset: 0x000561A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00057FB1 File Offset: 0x000561B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00057FE4 File Offset: 0x000561E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00058024 File Offset: 0x00056224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateDiceInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00058078 File Offset: 0x00056278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00058084 File Offset: 0x00056284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rogueDiceInfo_ == null)
					{
						this.RogueDiceInfo = new ChessRogueDiceInfo();
					}
					input.ReadMessage(this.RogueDiceInfo);
				}
			}
		}

		// Token: 0x04000CCA RID: 3274
		private static readonly MessageParser<ChessRogueUpdateDiceInfoScNotify> _parser = new MessageParser<ChessRogueUpdateDiceInfoScNotify>(() => new ChessRogueUpdateDiceInfoScNotify());

		// Token: 0x04000CCB RID: 3275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CCC RID: 3276
		public const int RogueDiceInfoFieldNumber = 8;

		// Token: 0x04000CCD RID: 3277
		private ChessRogueDiceInfo rogueDiceInfo_;
	}
}
