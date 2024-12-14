using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A7 RID: 4775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncTaskScRsp : IMessage<SyncTaskScRsp>, IMessage, IEquatable<SyncTaskScRsp>, IDeepCloneable<SyncTaskScRsp>, IBufferMessage
	{
		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600D4FF RID: 54527 RVA: 0x002388FC File Offset: 0x00236AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncTaskScRsp> Parser
		{
			get
			{
				return SyncTaskScRsp._parser;
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600D500 RID: 54528 RVA: 0x00238903 File Offset: 0x00236B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncTaskScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600D501 RID: 54529 RVA: 0x00238915 File Offset: 0x00236B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncTaskScRsp.Descriptor;
			}
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x0023891C File Offset: 0x00236B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskScRsp()
		{
		}

		// Token: 0x0600D503 RID: 54531 RVA: 0x0023892F File Offset: 0x00236B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskScRsp(SyncTaskScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.key_ = other.key_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D504 RID: 54532 RVA: 0x00238960 File Offset: 0x00236B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTaskScRsp Clone()
		{
			return new SyncTaskScRsp(this);
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600D505 RID: 54533 RVA: 0x00238968 File Offset: 0x00236B68
		// (set) Token: 0x0600D506 RID: 54534 RVA: 0x00238970 File Offset: 0x00236B70
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

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600D507 RID: 54535 RVA: 0x00238979 File Offset: 0x00236B79
		// (set) Token: 0x0600D508 RID: 54536 RVA: 0x00238981 File Offset: 0x00236B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Key
		{
			get
			{
				return this.key_;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0600D509 RID: 54537 RVA: 0x00238994 File Offset: 0x00236B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncTaskScRsp);
		}

		// Token: 0x0600D50A RID: 54538 RVA: 0x002389A4 File Offset: 0x00236BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncTaskScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && !(this.Key != other.Key) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D50B RID: 54539 RVA: 0x002389F4 File Offset: 0x00236BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Key.Length != 0)
			{
				num ^= this.Key.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D50C RID: 54540 RVA: 0x00238A4E File Offset: 0x00236C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D50D RID: 54541 RVA: 0x00238A56 File Offset: 0x00236C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D50E RID: 54542 RVA: 0x00238A60 File Offset: 0x00236C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Key.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.Key);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D50F RID: 54543 RVA: 0x00238AC0 File Offset: 0x00236CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Key.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D510 RID: 54544 RVA: 0x00238B1C File Offset: 0x00236D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncTaskScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Key.Length != 0)
			{
				this.Key = other.Key;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x00238B71 File Offset: 0x00236D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x00238B7C File Offset: 0x00236D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Key = input.ReadString();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400552B RID: 21803
		private static readonly MessageParser<SyncTaskScRsp> _parser = new MessageParser<SyncTaskScRsp>(() => new SyncTaskScRsp());

		// Token: 0x0400552C RID: 21804
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400552D RID: 21805
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400552E RID: 21806
		private uint retcode_;

		// Token: 0x0400552F RID: 21807
		public const int KeyFieldNumber = 15;

		// Token: 0x04005530 RID: 21808
		private string key_ = "";
	}
}
