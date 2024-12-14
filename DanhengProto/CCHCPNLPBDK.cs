using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000171 RID: 369
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CCHCPNLPBDK : IMessage<CCHCPNLPBDK>, IMessage, IEquatable<CCHCPNLPBDK>, IDeepCloneable<CCHCPNLPBDK>, IBufferMessage
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0002F7B7 File Offset: 0x0002D9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CCHCPNLPBDK> Parser
		{
			get
			{
				return CCHCPNLPBDK._parser;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0002F7BE File Offset: 0x0002D9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CCHCPNLPBDKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0002F7D0 File Offset: 0x0002D9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CCHCPNLPBDK.Descriptor;
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0002F7D7 File Offset: 0x0002D9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCHCPNLPBDK()
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCHCPNLPBDK(CCHCPNLPBDK other) : this()
		{
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this.eAHDBEIIOEF_ = ((other.eAHDBEIIOEF_ != null) ? other.eAHDBEIIOEF_.Clone() : null);
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0002F858 File Offset: 0x0002DA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CCHCPNLPBDK Clone()
		{
			return new CCHCPNLPBDK(this);
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0002F860 File Offset: 0x0002DA60
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x0002F868 File Offset: 0x0002DA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BCECCMOADLE BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0002F871 File Offset: 0x0002DA71
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x0002F879 File Offset: 0x0002DA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MFKOBPLMPIN EAHDBEIIOEF
		{
			get
			{
				return this.eAHDBEIIOEF_;
			}
			set
			{
				this.eAHDBEIIOEF_ = value;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0002F882 File Offset: 0x0002DA82
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0002F88A File Offset: 0x0002DA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002F893 File Offset: 0x0002DA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CCHCPNLPBDK);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CCHCPNLPBDK other)
		{
			return other != null && (other == this || (object.Equals(this.BasicInfo, other.BasicInfo) && object.Equals(this.EAHDBEIIOEF, other.EAHDBEIIOEF) && object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002F90C File Offset: 0x0002DB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			if (this.eAHDBEIIOEF_ != null)
			{
				num ^= this.EAHDBEIIOEF.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0002F974 File Offset: 0x0002DB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002F97C File Offset: 0x0002DB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002F988 File Offset: 0x0002DB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BasicInfo);
			}
			if (this.eAHDBEIIOEF_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.EAHDBEIIOEF);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StageInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002FA00 File Offset: 0x0002DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			if (this.eAHDBEIIOEF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EAHDBEIIOEF);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002FA70 File Offset: 0x0002DC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CCHCPNLPBDK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new BCECCMOADLE();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			if (other.eAHDBEIIOEF_ != null)
			{
				if (this.eAHDBEIIOEF_ == null)
				{
					this.EAHDBEIIOEF = new MFKOBPLMPIN();
				}
				this.EAHDBEIIOEF.MergeFrom(other.EAHDBEIIOEF);
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new PGDACNIBFMP();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002FB28 File Offset: 0x0002DD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.stageInfo_ == null)
							{
								this.StageInfo = new PGDACNIBFMP();
							}
							input.ReadMessage(this.StageInfo);
						}
					}
					else
					{
						if (this.eAHDBEIIOEF_ == null)
						{
							this.EAHDBEIIOEF = new MFKOBPLMPIN();
						}
						input.ReadMessage(this.EAHDBEIIOEF);
					}
				}
				else
				{
					if (this.basicInfo_ == null)
					{
						this.BasicInfo = new BCECCMOADLE();
					}
					input.ReadMessage(this.BasicInfo);
				}
			}
		}

		// Token: 0x040006E5 RID: 1765
		private static readonly MessageParser<CCHCPNLPBDK> _parser = new MessageParser<CCHCPNLPBDK>(() => new CCHCPNLPBDK());

		// Token: 0x040006E6 RID: 1766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040006E7 RID: 1767
		public const int BasicInfoFieldNumber = 1;

		// Token: 0x040006E8 RID: 1768
		private BCECCMOADLE basicInfo_;

		// Token: 0x040006E9 RID: 1769
		public const int EAHDBEIIOEFFieldNumber = 2;

		// Token: 0x040006EA RID: 1770
		private MFKOBPLMPIN eAHDBEIIOEF_;

		// Token: 0x040006EB RID: 1771
		public const int StageInfoFieldNumber = 3;

		// Token: 0x040006EC RID: 1772
		private PGDACNIBFMP stageInfo_;
	}
}
