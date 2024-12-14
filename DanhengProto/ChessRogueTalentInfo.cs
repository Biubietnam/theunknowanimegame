using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002A5 RID: 677
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueTalentInfo : IMessage<ChessRogueTalentInfo>, IMessage, IEquatable<ChessRogueTalentInfo>, IDeepCloneable<ChessRogueTalentInfo>, IBufferMessage
	{
		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00056F2F File Offset: 0x0005512F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueTalentInfo> Parser
		{
			get
			{
				return ChessRogueTalentInfo._parser;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00056F36 File Offset: 0x00055136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueTalentInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00056F48 File Offset: 0x00055148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueTalentInfo.Descriptor;
			}
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00056F4F File Offset: 0x0005514F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueTalentInfo()
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00056F58 File Offset: 0x00055158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueTalentInfo(ChessRogueTalentInfo other) : this()
		{
			this.rogueTalentInfoList_ = ((other.rogueTalentInfoList_ != null) ? other.rogueTalentInfoList_.Clone() : null);
			this.fCAAGLKFAID_ = other.fCAAGLKFAID_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00056FA4 File Offset: 0x000551A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueTalentInfo Clone()
		{
			return new ChessRogueTalentInfo(this);
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x00056FAC File Offset: 0x000551AC
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x00056FB4 File Offset: 0x000551B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList RogueTalentInfoList
		{
			get
			{
				return this.rogueTalentInfoList_;
			}
			set
			{
				this.rogueTalentInfoList_ = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x00056FBD File Offset: 0x000551BD
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x00056FC5 File Offset: 0x000551C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FCAAGLKFAID
		{
			get
			{
				return this.fCAAGLKFAID_;
			}
			set
			{
				this.fCAAGLKFAID_ = value;
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00056FCE File Offset: 0x000551CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueTalentInfo);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00056FDC File Offset: 0x000551DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueTalentInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTalentInfoList, other.RogueTalentInfoList) && this.FCAAGLKFAID == other.FCAAGLKFAID && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0005702C File Offset: 0x0005522C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTalentInfoList_ != null)
			{
				num ^= this.RogueTalentInfoList.GetHashCode();
			}
			if (this.FCAAGLKFAID != 0U)
			{
				num ^= this.FCAAGLKFAID.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00057081 File Offset: 0x00055281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00057089 File Offset: 0x00055289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00057094 File Offset: 0x00055294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTalentInfoList_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueTalentInfoList);
			}
			if (this.FCAAGLKFAID != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.FCAAGLKFAID);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000570F0 File Offset: 0x000552F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTalentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTalentInfoList);
			}
			if (this.FCAAGLKFAID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FCAAGLKFAID);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00057148 File Offset: 0x00055348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTalentInfoList_ != null)
			{
				if (this.rogueTalentInfoList_ == null)
				{
					this.RogueTalentInfoList = new RogueTalentInfoList();
				}
				this.RogueTalentInfoList.MergeFrom(other.RogueTalentInfoList);
			}
			if (other.FCAAGLKFAID != 0U)
			{
				this.FCAAGLKFAID = other.FCAAGLKFAID;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000571B0 File Offset: 0x000553B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x000571BC File Offset: 0x000553BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FCAAGLKFAID = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueTalentInfoList_ == null)
					{
						this.RogueTalentInfoList = new RogueTalentInfoList();
					}
					input.ReadMessage(this.RogueTalentInfoList);
				}
			}
		}

		// Token: 0x04000CAA RID: 3242
		private static readonly MessageParser<ChessRogueTalentInfo> _parser = new MessageParser<ChessRogueTalentInfo>(() => new ChessRogueTalentInfo());

		// Token: 0x04000CAB RID: 3243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CAC RID: 3244
		public const int RogueTalentInfoListFieldNumber = 4;

		// Token: 0x04000CAD RID: 3245
		private RogueTalentInfoList rogueTalentInfoList_;

		// Token: 0x04000CAE RID: 3246
		public const int FCAAGLKFAIDFieldNumber = 14;

		// Token: 0x04000CAF RID: 3247
		private uint fCAAGLKFAID_;
	}
}
