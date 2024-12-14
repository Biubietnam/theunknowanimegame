using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012FB RID: 4859
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffEquipmentScRsp : IMessage<TakeOffEquipmentScRsp>, IMessage, IEquatable<TakeOffEquipmentScRsp>, IDeepCloneable<TakeOffEquipmentScRsp>, IBufferMessage
	{
		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600D8CB RID: 55499 RVA: 0x00241F68 File Offset: 0x00240168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffEquipmentScRsp> Parser
		{
			get
			{
				return TakeOffEquipmentScRsp._parser;
			}
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600D8CC RID: 55500 RVA: 0x00241F6F File Offset: 0x0024016F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffEquipmentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600D8CD RID: 55501 RVA: 0x00241F81 File Offset: 0x00240181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffEquipmentScRsp.Descriptor;
			}
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x00241F88 File Offset: 0x00240188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentScRsp()
		{
		}

		// Token: 0x0600D8CF RID: 55503 RVA: 0x00241F90 File Offset: 0x00240190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentScRsp(TakeOffEquipmentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8D0 RID: 55504 RVA: 0x00241FB5 File Offset: 0x002401B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentScRsp Clone()
		{
			return new TakeOffEquipmentScRsp(this);
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x00241FBD File Offset: 0x002401BD
		// (set) Token: 0x0600D8D2 RID: 55506 RVA: 0x00241FC5 File Offset: 0x002401C5
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

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x00241FCE File Offset: 0x002401CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffEquipmentScRsp);
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x00241FDC File Offset: 0x002401DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffEquipmentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8D5 RID: 55509 RVA: 0x0024200C File Offset: 0x0024020C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x0024204B File Offset: 0x0024024B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x00242053 File Offset: 0x00240253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x0024205C File Offset: 0x0024025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x00242090 File Offset: 0x00240290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D8DA RID: 55514 RVA: 0x002420CE File Offset: 0x002402CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffEquipmentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x002420FF File Offset: 0x002402FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x00242108 File Offset: 0x00240308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005677 RID: 22135
		private static readonly MessageParser<TakeOffEquipmentScRsp> _parser = new MessageParser<TakeOffEquipmentScRsp>(() => new TakeOffEquipmentScRsp());

		// Token: 0x04005678 RID: 22136
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005679 RID: 22137
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400567A RID: 22138
		private uint retcode_;
	}
}
