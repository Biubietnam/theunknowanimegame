using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F8F RID: 3983
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournCurInfo : IMessage<RogueTournCurInfo>, IMessage, IEquatable<RogueTournCurInfo>, IDeepCloneable<RogueTournCurInfo>, IBufferMessage
	{
		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600B179 RID: 45433 RVA: 0x001DD343 File Offset: 0x001DB543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournCurInfo> Parser
		{
			get
			{
				return RogueTournCurInfo._parser;
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600B17A RID: 45434 RVA: 0x001DD34A File Offset: 0x001DB54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournCurInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600B17B RID: 45435 RVA: 0x001DD35C File Offset: 0x001DB55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournCurInfo.Descriptor;
			}
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x001DD363 File Offset: 0x001DB563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo()
		{
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x001DD36C File Offset: 0x001DB56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo(RogueTournCurInfo other) : this()
		{
			this.rogueTournCurAreaInfo_ = ((other.rogueTournCurAreaInfo_ != null) ? other.rogueTournCurAreaInfo_.Clone() : null);
			this.rogueTournCurGameInfo_ = ((other.rogueTournCurGameInfo_ != null) ? other.rogueTournCurGameInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B17E RID: 45438 RVA: 0x001DD3C8 File Offset: 0x001DB5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurInfo Clone()
		{
			return new RogueTournCurInfo(this);
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600B17F RID: 45439 RVA: 0x001DD3D0 File Offset: 0x001DB5D0
		// (set) Token: 0x0600B180 RID: 45440 RVA: 0x001DD3D8 File Offset: 0x001DB5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurAreaInfo RogueTournCurAreaInfo
		{
			get
			{
				return this.rogueTournCurAreaInfo_;
			}
			set
			{
				this.rogueTournCurAreaInfo_ = value;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600B181 RID: 45441 RVA: 0x001DD3E1 File Offset: 0x001DB5E1
		// (set) Token: 0x0600B182 RID: 45442 RVA: 0x001DD3E9 File Offset: 0x001DB5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurGameInfo RogueTournCurGameInfo
		{
			get
			{
				return this.rogueTournCurGameInfo_;
			}
			set
			{
				this.rogueTournCurGameInfo_ = value;
			}
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x001DD3F2 File Offset: 0x001DB5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournCurInfo);
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x001DD400 File Offset: 0x001DB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournCurInfo other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurAreaInfo, other.RogueTournCurAreaInfo) && object.Equals(this.RogueTournCurGameInfo, other.RogueTournCurGameInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x001DD454 File Offset: 0x001DB654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurAreaInfo_ != null)
			{
				num ^= this.RogueTournCurAreaInfo.GetHashCode();
			}
			if (this.rogueTournCurGameInfo_ != null)
			{
				num ^= this.RogueTournCurGameInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x001DD4A6 File Offset: 0x001DB6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x001DD4AE File Offset: 0x001DB6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x001DD4B8 File Offset: 0x001DB6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurAreaInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueTournCurAreaInfo);
			}
			if (this.rogueTournCurGameInfo_ != null)
			{
				output.WriteRawTag(194, 18);
				output.WriteMessage(this.RogueTournCurGameInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x001DD518 File Offset: 0x001DB718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurAreaInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurAreaInfo);
			}
			if (this.rogueTournCurGameInfo_ != null)
			{
				num += 2 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurGameInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x001DD570 File Offset: 0x001DB770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournCurInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurAreaInfo_ != null)
			{
				if (this.rogueTournCurAreaInfo_ == null)
				{
					this.RogueTournCurAreaInfo = new RogueTournCurAreaInfo();
				}
				this.RogueTournCurAreaInfo.MergeFrom(other.RogueTournCurAreaInfo);
			}
			if (other.rogueTournCurGameInfo_ != null)
			{
				if (this.rogueTournCurGameInfo_ == null)
				{
					this.RogueTournCurGameInfo = new RogueTournCurGameInfo();
				}
				this.RogueTournCurGameInfo.MergeFrom(other.RogueTournCurGameInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x001DD5F0 File Offset: 0x001DB7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x001DD5FC File Offset: 0x001DB7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					if (num != 2370U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueTournCurGameInfo_ == null)
						{
							this.RogueTournCurGameInfo = new RogueTournCurGameInfo();
						}
						input.ReadMessage(this.RogueTournCurGameInfo);
					}
				}
				else
				{
					if (this.rogueTournCurAreaInfo_ == null)
					{
						this.RogueTournCurAreaInfo = new RogueTournCurAreaInfo();
					}
					input.ReadMessage(this.RogueTournCurAreaInfo);
				}
			}
		}

		// Token: 0x0400483A RID: 18490
		private static readonly MessageParser<RogueTournCurInfo> _parser = new MessageParser<RogueTournCurInfo>(() => new RogueTournCurInfo());

		// Token: 0x0400483B RID: 18491
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400483C RID: 18492
		public const int RogueTournCurAreaInfoFieldNumber = 12;

		// Token: 0x0400483D RID: 18493
		private RogueTournCurAreaInfo rogueTournCurAreaInfo_;

		// Token: 0x0400483E RID: 18494
		public const int RogueTournCurGameInfoFieldNumber = 296;

		// Token: 0x0400483F RID: 18495
		private RogueTournCurGameInfo rogueTournCurGameInfo_;
	}
}
