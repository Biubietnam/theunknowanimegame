using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200025D RID: 605
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousMainStoryInfo : IMessage<ChessRogueNousMainStoryInfo>, IMessage, IEquatable<ChessRogueNousMainStoryInfo>, IDeepCloneable<ChessRogueNousMainStoryInfo>, IBufferMessage
	{
		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x0004E43F File Offset: 0x0004C63F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousMainStoryInfo> Parser
		{
			get
			{
				return ChessRogueNousMainStoryInfo._parser;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0004E446 File Offset: 0x0004C646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousMainStoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0004E458 File Offset: 0x0004C658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousMainStoryInfo.Descriptor;
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0004E45F File Offset: 0x0004C65F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousMainStoryInfo()
		{
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0004E467 File Offset: 0x0004C667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousMainStoryInfo(ChessRogueNousMainStoryInfo other) : this()
		{
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0004E498 File Offset: 0x0004C698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousMainStoryInfo Clone()
		{
			return new ChessRogueNousMainStoryInfo(this);
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0004E4A0 File Offset: 0x0004C6A0
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0004E4A8 File Offset: 0x0004C6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0004E4B1 File Offset: 0x0004C6B1
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0004E4B9 File Offset: 0x0004C6B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousMainStoryStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004E4C2 File Offset: 0x0004C6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousMainStoryInfo);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0004E4D0 File Offset: 0x0004C6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousMainStoryInfo other)
		{
			return other != null && (other == this || (this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0004E510 File Offset: 0x0004C710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			if (this.Status != ChessRogueNousMainStoryStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0004E56E File Offset: 0x0004C76E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0004E576 File Offset: 0x0004C776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0004E580 File Offset: 0x0004C780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this.Status != ChessRogueNousMainStoryStatus.None)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			if (this.Status != ChessRogueNousMainStoryStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0004E634 File Offset: 0x0004C834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousMainStoryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			if (other.Status != ChessRogueNousMainStoryStatus.None)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004E684 File Offset: 0x0004C884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0004E690 File Offset: 0x0004C890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (ChessRogueNousMainStoryStatus)input.ReadEnum();
					}
				}
				else
				{
					this.ChessRogueMainStoryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B6E RID: 2926
		private static readonly MessageParser<ChessRogueNousMainStoryInfo> _parser = new MessageParser<ChessRogueNousMainStoryInfo>(() => new ChessRogueNousMainStoryInfo());

		// Token: 0x04000B6F RID: 2927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B70 RID: 2928
		public const int ChessRogueMainStoryIdFieldNumber = 3;

		// Token: 0x04000B71 RID: 2929
		private uint chessRogueMainStoryId_;

		// Token: 0x04000B72 RID: 2930
		public const int StatusFieldNumber = 7;

		// Token: 0x04000B73 RID: 2931
		private ChessRogueNousMainStoryStatus status_;
	}
}
