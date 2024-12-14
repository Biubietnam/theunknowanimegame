using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000899 RID: 2201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HealPoolInfo : IMessage<HealPoolInfo>, IMessage, IEquatable<HealPoolInfo>, IDeepCloneable<HealPoolInfo>, IBufferMessage
	{
		// Token: 0x17001BA8 RID: 7080
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x00106FE0 File Offset: 0x001051E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HealPoolInfo> Parser
		{
			get
			{
				return HealPoolInfo._parser;
			}
		}

		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600623E RID: 25150 RVA: 0x00106FE7 File Offset: 0x001051E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HealPoolInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BAA RID: 7082
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x00106FF9 File Offset: 0x001051F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HealPoolInfo.Descriptor;
			}
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x00107000 File Offset: 0x00105200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo()
		{
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x00107008 File Offset: 0x00105208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo(HealPoolInfo other) : this()
		{
			this.refreshTime_ = other.refreshTime_;
			this.healPool_ = other.healPool_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x00107039 File Offset: 0x00105239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HealPoolInfo Clone()
		{
			return new HealPoolInfo(this);
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x00107041 File Offset: 0x00105241
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x00107049 File Offset: 0x00105249
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x00107052 File Offset: 0x00105252
		// (set) Token: 0x06006246 RID: 25158 RVA: 0x0010705A File Offset: 0x0010525A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HealPool
		{
			get
			{
				return this.healPool_;
			}
			set
			{
				this.healPool_ = value;
			}
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x00107063 File Offset: 0x00105263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HealPoolInfo);
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x00107071 File Offset: 0x00105271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HealPoolInfo other)
		{
			return other != null && (other == this || (this.RefreshTime == other.RefreshTime && this.HealPool == other.HealPool && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x001070B0 File Offset: 0x001052B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this.HealPool != 0U)
			{
				num ^= this.HealPool.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x00107108 File Offset: 0x00105308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x00107110 File Offset: 0x00105310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x0010711C File Offset: 0x0010531C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RefreshTime);
			}
			if (this.HealPool != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.HealPool);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x00107178 File Offset: 0x00105378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this.HealPool != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HealPool);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x001071D0 File Offset: 0x001053D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HealPoolInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			if (other.HealPool != 0U)
			{
				this.HealPool = other.HealPool;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x00107220 File Offset: 0x00105420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0010722C File Offset: 0x0010542C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HealPool = input.ReadUInt32();
					}
				}
				else
				{
					this.RefreshTime = input.ReadInt64();
				}
			}
		}

		// Token: 0x040025C5 RID: 9669
		private static readonly MessageParser<HealPoolInfo> _parser = new MessageParser<HealPoolInfo>(() => new HealPoolInfo());

		// Token: 0x040025C6 RID: 9670
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025C7 RID: 9671
		public const int RefreshTimeFieldNumber = 2;

		// Token: 0x040025C8 RID: 9672
		private long refreshTime_;

		// Token: 0x040025C9 RID: 9673
		public const int HealPoolFieldNumber = 10;

		// Token: 0x040025CA RID: 9674
		private uint healPool_;
	}
}
