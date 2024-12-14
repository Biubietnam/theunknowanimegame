using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C9 RID: 1481
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendRecommendInfo : IMessage<FriendRecommendInfo>, IMessage, IEquatable<FriendRecommendInfo>, IDeepCloneable<FriendRecommendInfo>, IBufferMessage
	{
		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06004208 RID: 16904 RVA: 0x000B3AFD File Offset: 0x000B1CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendRecommendInfo> Parser
		{
			get
			{
				return FriendRecommendInfo._parser;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06004209 RID: 16905 RVA: 0x000B3B04 File Offset: 0x000B1D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendRecommendInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600420A RID: 16906 RVA: 0x000B3B16 File Offset: 0x000B1D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecommendInfo.Descriptor;
			}
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x000B3B1D File Offset: 0x000B1D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecommendInfo()
		{
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x000B3B28 File Offset: 0x000B1D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecommendInfo(FriendRecommendInfo other) : this()
		{
			this.nBHIADFEKFF_ = other.nBHIADFEKFF_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600420D RID: 16909 RVA: 0x000B3B74 File Offset: 0x000B1D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecommendInfo Clone()
		{
			return new FriendRecommendInfo(this);
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x000B3B7C File Offset: 0x000B1D7C
		// (set) Token: 0x0600420F RID: 16911 RVA: 0x000B3B84 File Offset: 0x000B1D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NBHIADFEKFF
		{
			get
			{
				return this.nBHIADFEKFF_;
			}
			set
			{
				this.nBHIADFEKFF_ = value;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x000B3B8D File Offset: 0x000B1D8D
		// (set) Token: 0x06004211 RID: 16913 RVA: 0x000B3B95 File Offset: 0x000B1D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x000B3B9E File Offset: 0x000B1D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecommendInfo);
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x000B3BAC File Offset: 0x000B1DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecommendInfo other)
		{
			return other != null && (other == this || (this.NBHIADFEKFF == other.NBHIADFEKFF && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004214 RID: 16916 RVA: 0x000B3BFC File Offset: 0x000B1DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NBHIADFEKFF)
			{
				num ^= this.NBHIADFEKFF.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004215 RID: 16917 RVA: 0x000B3C51 File Offset: 0x000B1E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004216 RID: 16918 RVA: 0x000B3C59 File Offset: 0x000B1E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004217 RID: 16919 RVA: 0x000B3C64 File Offset: 0x000B1E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NBHIADFEKFF)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NBHIADFEKFF);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000B3CC0 File Offset: 0x000B1EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NBHIADFEKFF)
			{
				num += 2;
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x000B3D0C File Offset: 0x000B1F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NBHIADFEKFF)
			{
				this.NBHIADFEKFF = other.NBHIADFEKFF;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new PlayerSimpleInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x000B3D74 File Offset: 0x000B1F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x000B3D80 File Offset: 0x000B1F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new PlayerSimpleInfo();
						}
						input.ReadMessage(this.PlayerInfo);
					}
				}
				else
				{
					this.NBHIADFEKFF = input.ReadBool();
				}
			}
		}

		// Token: 0x04001A36 RID: 6710
		private static readonly MessageParser<FriendRecommendInfo> _parser = new MessageParser<FriendRecommendInfo>(() => new FriendRecommendInfo());

		// Token: 0x04001A37 RID: 6711
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A38 RID: 6712
		public const int NBHIADFEKFFFieldNumber = 11;

		// Token: 0x04001A39 RID: 6713
		private bool nBHIADFEKFF_;

		// Token: 0x04001A3A RID: 6714
		public const int PlayerInfoFieldNumber = 13;

		// Token: 0x04001A3B RID: 6715
		private PlayerSimpleInfo playerInfo_;
	}
}
