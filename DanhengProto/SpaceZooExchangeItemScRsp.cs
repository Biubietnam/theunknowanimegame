using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001169 RID: 4457
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooExchangeItemScRsp : IMessage<SpaceZooExchangeItemScRsp>, IMessage, IEquatable<SpaceZooExchangeItemScRsp>, IDeepCloneable<SpaceZooExchangeItemScRsp>, IBufferMessage
	{
		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600C6D7 RID: 50903 RVA: 0x00215BB1 File Offset: 0x00213DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooExchangeItemScRsp> Parser
		{
			get
			{
				return SpaceZooExchangeItemScRsp._parser;
			}
		}

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600C6D8 RID: 50904 RVA: 0x00215BB8 File Offset: 0x00213DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooExchangeItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600C6D9 RID: 50905 RVA: 0x00215BCA File Offset: 0x00213DCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooExchangeItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600C6DA RID: 50906 RVA: 0x00215BD1 File Offset: 0x00213DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemScRsp()
		{
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x00215BD9 File Offset: 0x00213DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemScRsp(SpaceZooExchangeItemScRsp other) : this()
		{
			this.itemId_ = other.itemId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x00215C0A File Offset: 0x00213E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooExchangeItemScRsp Clone()
		{
			return new SpaceZooExchangeItemScRsp(this);
		}

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600C6DD RID: 50909 RVA: 0x00215C12 File Offset: 0x00213E12
		// (set) Token: 0x0600C6DE RID: 50910 RVA: 0x00215C1A File Offset: 0x00213E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600C6DF RID: 50911 RVA: 0x00215C23 File Offset: 0x00213E23
		// (set) Token: 0x0600C6E0 RID: 50912 RVA: 0x00215C2B File Offset: 0x00213E2B
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

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x00215C34 File Offset: 0x00213E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooExchangeItemScRsp);
		}

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00215C42 File Offset: 0x00213E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooExchangeItemScRsp other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x00215C80 File Offset: 0x00213E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00215CD8 File Offset: 0x00213ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x00215CE0 File Offset: 0x00213EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00215CEC File Offset: 0x00213EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00215D48 File Offset: 0x00213F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00215DA0 File Offset: 0x00213FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooExchangeItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x00215DF0 File Offset: 0x00213FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x00215DFC File Offset: 0x00213FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005059 RID: 20569
		private static readonly MessageParser<SpaceZooExchangeItemScRsp> _parser = new MessageParser<SpaceZooExchangeItemScRsp>(() => new SpaceZooExchangeItemScRsp());

		// Token: 0x0400505A RID: 20570
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400505B RID: 20571
		public const int ItemIdFieldNumber = 14;

		// Token: 0x0400505C RID: 20572
		private uint itemId_;

		// Token: 0x0400505D RID: 20573
		public const int RetcodeFieldNumber = 11;

		// Token: 0x0400505E RID: 20574
		private uint retcode_;
	}
}
