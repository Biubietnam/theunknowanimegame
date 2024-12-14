using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001001 RID: 4097
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournRenameArchiveCsReq : IMessage<RogueTournRenameArchiveCsReq>, IMessage, IEquatable<RogueTournRenameArchiveCsReq>, IDeepCloneable<RogueTournRenameArchiveCsReq>, IBufferMessage
	{
		// Token: 0x1700335D RID: 13149
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x001E92B5 File Offset: 0x001E74B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournRenameArchiveCsReq> Parser
		{
			get
			{
				return RogueTournRenameArchiveCsReq._parser;
			}
		}

		// Token: 0x1700335E RID: 13150
		// (get) Token: 0x0600B64B RID: 46667 RVA: 0x001E92BC File Offset: 0x001E74BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournRenameArchiveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x001E92CE File Offset: 0x001E74CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournRenameArchiveCsReq.Descriptor;
			}
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x001E92D5 File Offset: 0x001E74D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveCsReq()
		{
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x001E92E8 File Offset: 0x001E74E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveCsReq(RogueTournRenameArchiveCsReq other) : this()
		{
			this.name_ = other.name_;
			this.maxTimes_ = other.maxTimes_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x001E9319 File Offset: 0x001E7519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournRenameArchiveCsReq Clone()
		{
			return new RogueTournRenameArchiveCsReq(this);
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600B650 RID: 46672 RVA: 0x001E9321 File Offset: 0x001E7521
		// (set) Token: 0x0600B651 RID: 46673 RVA: 0x001E9329 File Offset: 0x001E7529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600B652 RID: 46674 RVA: 0x001E933C File Offset: 0x001E753C
		// (set) Token: 0x0600B653 RID: 46675 RVA: 0x001E9344 File Offset: 0x001E7544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxTimes
		{
			get
			{
				return this.maxTimes_;
			}
			set
			{
				this.maxTimes_ = value;
			}
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x001E934D File Offset: 0x001E754D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournRenameArchiveCsReq);
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x001E935C File Offset: 0x001E755C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournRenameArchiveCsReq other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && this.MaxTimes == other.MaxTimes && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x001E93AC File Offset: 0x001E75AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.MaxTimes != 0U)
			{
				num ^= this.MaxTimes.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x001E9406 File Offset: 0x001E7606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x001E940E File Offset: 0x001E760E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x001E9418 File Offset: 0x001E7618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxTimes != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxTimes);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x001E9478 File Offset: 0x001E7678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.MaxTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxTimes);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x001E94D4 File Offset: 0x001E76D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournRenameArchiveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.MaxTimes != 0U)
			{
				this.MaxTimes = other.MaxTimes;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x001E9529 File Offset: 0x001E7729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x001E9534 File Offset: 0x001E7734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.MaxTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040049E2 RID: 18914
		private static readonly MessageParser<RogueTournRenameArchiveCsReq> _parser = new MessageParser<RogueTournRenameArchiveCsReq>(() => new RogueTournRenameArchiveCsReq());

		// Token: 0x040049E3 RID: 18915
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049E4 RID: 18916
		public const int NameFieldNumber = 9;

		// Token: 0x040049E5 RID: 18917
		private string name_ = "";

		// Token: 0x040049E6 RID: 18918
		public const int MaxTimesFieldNumber = 2;

		// Token: 0x040049E7 RID: 18919
		private uint maxTimes_;
	}
}
