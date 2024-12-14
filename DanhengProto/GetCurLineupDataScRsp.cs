using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000679 RID: 1657
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetCurLineupDataScRsp : IMessage<GetCurLineupDataScRsp>, IMessage, IEquatable<GetCurLineupDataScRsp>, IDeepCloneable<GetCurLineupDataScRsp>, IBufferMessage
	{
		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x000CA1C5 File Offset: 0x000C83C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetCurLineupDataScRsp> Parser
		{
			get
			{
				return GetCurLineupDataScRsp._parser;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x000CA1CC File Offset: 0x000C83CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetCurLineupDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06004A3D RID: 19005 RVA: 0x000CA1DE File Offset: 0x000C83DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetCurLineupDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x000CA1E5 File Offset: 0x000C83E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataScRsp()
		{
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x000CA1F0 File Offset: 0x000C83F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataScRsp(GetCurLineupDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x000CA23C File Offset: 0x000C843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetCurLineupDataScRsp Clone()
		{
			return new GetCurLineupDataScRsp(this);
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06004A41 RID: 19009 RVA: 0x000CA244 File Offset: 0x000C8444
		// (set) Token: 0x06004A42 RID: 19010 RVA: 0x000CA24C File Offset: 0x000C844C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06004A43 RID: 19011 RVA: 0x000CA255 File Offset: 0x000C8455
		// (set) Token: 0x06004A44 RID: 19012 RVA: 0x000CA25D File Offset: 0x000C845D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x000CA266 File Offset: 0x000C8466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetCurLineupDataScRsp);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x000CA274 File Offset: 0x000C8474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetCurLineupDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Lineup, other.Lineup) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x000CA2C4 File Offset: 0x000C84C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x000CA319 File Offset: 0x000C8519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x000CA321 File Offset: 0x000C8521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x000CA32C File Offset: 0x000C852C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x000CA388 File Offset: 0x000C8588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetCurLineupDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x000CA448 File Offset: 0x000C8648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A4E RID: 19022 RVA: 0x000CA454 File Offset: 0x000C8654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001D7B RID: 7547
		private static readonly MessageParser<GetCurLineupDataScRsp> _parser = new MessageParser<GetCurLineupDataScRsp>(() => new GetCurLineupDataScRsp());

		// Token: 0x04001D7C RID: 7548
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D7D RID: 7549
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04001D7E RID: 7550
		private uint retcode_;

		// Token: 0x04001D7F RID: 7551
		public const int LineupFieldNumber = 14;

		// Token: 0x04001D80 RID: 7552
		private LineupInfo lineup_;
	}
}
