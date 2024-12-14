using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F73 RID: 3955
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueSeasonInfo : IMessage<RogueSeasonInfo>, IMessage, IEquatable<RogueSeasonInfo>, IDeepCloneable<RogueSeasonInfo>, IBufferMessage
	{
		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x0600B043 RID: 45123 RVA: 0x001D9959 File Offset: 0x001D7B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueSeasonInfo> Parser
		{
			get
			{
				return RogueSeasonInfo._parser;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x0600B044 RID: 45124 RVA: 0x001D9960 File Offset: 0x001D7B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueSeasonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031BA RID: 12730
		// (get) Token: 0x0600B045 RID: 45125 RVA: 0x001D9972 File Offset: 0x001D7B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSeasonInfo.Descriptor;
			}
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x001D9979 File Offset: 0x001D7B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonInfo()
		{
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x001D9981 File Offset: 0x001D7B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonInfo(RogueSeasonInfo other) : this()
		{
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this.season_ = other.season_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x001D99BE File Offset: 0x001D7BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonInfo Clone()
		{
			return new RogueSeasonInfo(this);
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600B049 RID: 45129 RVA: 0x001D99C6 File Offset: 0x001D7BC6
		// (set) Token: 0x0600B04A RID: 45130 RVA: 0x001D99CE File Offset: 0x001D7BCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x001D99D7 File Offset: 0x001D7BD7
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x001D99DF File Offset: 0x001D7BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x170031BD RID: 12733
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x001D99E8 File Offset: 0x001D7BE8
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x001D99F0 File Offset: 0x001D7BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Season
		{
			get
			{
				return this.season_;
			}
			set
			{
				this.season_ = value;
			}
		}

		// Token: 0x0600B04F RID: 45135 RVA: 0x001D99F9 File Offset: 0x001D7BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSeasonInfo);
		}

		// Token: 0x0600B050 RID: 45136 RVA: 0x001D9A08 File Offset: 0x001D7C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSeasonInfo other)
		{
			return other != null && (other == this || (this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && this.Season == other.Season && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B051 RID: 45137 RVA: 0x001D9A64 File Offset: 0x001D7C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this.Season != 0U)
			{
				num ^= this.Season.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B052 RID: 45138 RVA: 0x001D9AD5 File Offset: 0x001D7CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x001D9ADD File Offset: 0x001D7CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x001D9AE8 File Offset: 0x001D7CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.Season != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Season);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x001D9B60 File Offset: 0x001D7D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this.Season != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Season);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueSeasonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			if (other.Season != 0U)
			{
				this.Season = other.Season;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x001D9C34 File Offset: 0x001D7E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x001D9C40 File Offset: 0x001D7E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.Season = input.ReadUInt32();
					}
				}
				else
				{
					this.BeginTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040047B4 RID: 18356
		private static readonly MessageParser<RogueSeasonInfo> _parser = new MessageParser<RogueSeasonInfo>(() => new RogueSeasonInfo());

		// Token: 0x040047B5 RID: 18357
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047B6 RID: 18358
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x040047B7 RID: 18359
		private long beginTime_;

		// Token: 0x040047B8 RID: 18360
		public const int EndTimeFieldNumber = 12;

		// Token: 0x040047B9 RID: 18361
		private long endTime_;

		// Token: 0x040047BA RID: 18362
		public const int SeasonFieldNumber = 4;

		// Token: 0x040047BB RID: 18363
		private uint season_;
	}
}
