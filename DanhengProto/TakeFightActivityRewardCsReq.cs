using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012D7 RID: 4823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeFightActivityRewardCsReq : IMessage<TakeFightActivityRewardCsReq>, IMessage, IEquatable<TakeFightActivityRewardCsReq>, IDeepCloneable<TakeFightActivityRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600D729 RID: 55081 RVA: 0x0023DD2D File Offset: 0x0023BF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeFightActivityRewardCsReq> Parser
		{
			get
			{
				return TakeFightActivityRewardCsReq._parser;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600D72A RID: 55082 RVA: 0x0023DD34 File Offset: 0x0023BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeFightActivityRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600D72B RID: 55083 RVA: 0x0023DD46 File Offset: 0x0023BF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeFightActivityRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x0023DD4D File Offset: 0x0023BF4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardCsReq()
		{
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x0023DD55 File Offset: 0x0023BF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardCsReq(TakeFightActivityRewardCsReq other) : this()
		{
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D72E RID: 55086 RVA: 0x0023DD86 File Offset: 0x0023BF86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeFightActivityRewardCsReq Clone()
		{
			return new TakeFightActivityRewardCsReq(this);
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600D72F RID: 55087 RVA: 0x0023DD8E File Offset: 0x0023BF8E
		// (set) Token: 0x0600D730 RID: 55088 RVA: 0x0023DD96 File Offset: 0x0023BF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600D731 RID: 55089 RVA: 0x0023DD9F File Offset: 0x0023BF9F
		// (set) Token: 0x0600D732 RID: 55090 RVA: 0x0023DDA7 File Offset: 0x0023BFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600D733 RID: 55091 RVA: 0x0023DDB0 File Offset: 0x0023BFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeFightActivityRewardCsReq);
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x0023DDBE File Offset: 0x0023BFBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeFightActivityRewardCsReq other)
		{
			return other != null && (other == this || (this.AHFNGPLDAII == other.AHFNGPLDAII && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x0023DDFC File Offset: 0x0023BFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D736 RID: 55094 RVA: 0x0023DE54 File Offset: 0x0023C054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x0023DE5C File Offset: 0x0023C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x0023DE68 File Offset: 0x0023C068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GroupId);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x0023DEC4 File Offset: 0x0023C0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x0023DF1C File Offset: 0x0023C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeFightActivityRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D73B RID: 55099 RVA: 0x0023DF6C File Offset: 0x0023C16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D73C RID: 55100 RVA: 0x0023DF78 File Offset: 0x0023C178
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
						this.AHFNGPLDAII = input.ReadUInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055E1 RID: 21985
		private static readonly MessageParser<TakeFightActivityRewardCsReq> _parser = new MessageParser<TakeFightActivityRewardCsReq>(() => new TakeFightActivityRewardCsReq());

		// Token: 0x040055E2 RID: 21986
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055E3 RID: 21987
		public const int AHFNGPLDAIIFieldNumber = 7;

		// Token: 0x040055E4 RID: 21988
		private uint aHFNGPLDAII_;

		// Token: 0x040055E5 RID: 21989
		public const int GroupIdFieldNumber = 3;

		// Token: 0x040055E6 RID: 21990
		private uint groupId_;
	}
}
