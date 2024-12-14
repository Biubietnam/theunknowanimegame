using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200104B RID: 4171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SavePointsInfoNotify : IMessage<SavePointsInfoNotify>, IMessage, IEquatable<SavePointsInfoNotify>, IDeepCloneable<SavePointsInfoNotify>, IBufferMessage
	{
		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600B98B RID: 47499 RVA: 0x001F20A4 File Offset: 0x001F02A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SavePointsInfoNotify> Parser
		{
			get
			{
				return SavePointsInfoNotify._parser;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600B98C RID: 47500 RVA: 0x001F20AB File Offset: 0x001F02AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SavePointsInfoNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600B98D RID: 47501 RVA: 0x001F20BD File Offset: 0x001F02BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SavePointsInfoNotify.Descriptor;
			}
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x001F20C4 File Offset: 0x001F02C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SavePointsInfoNotify()
		{
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x001F20CC File Offset: 0x001F02CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SavePointsInfoNotify(SavePointsInfoNotify other) : this()
		{
			this.validTimes_ = other.validTimes_;
			this.refreshTime_ = other.refreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x001F20FD File Offset: 0x001F02FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SavePointsInfoNotify Clone()
		{
			return new SavePointsInfoNotify(this);
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600B991 RID: 47505 RVA: 0x001F2105 File Offset: 0x001F0305
		// (set) Token: 0x0600B992 RID: 47506 RVA: 0x001F210D File Offset: 0x001F030D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ValidTimes
		{
			get
			{
				return this.validTimes_;
			}
			set
			{
				this.validTimes_ = value;
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600B993 RID: 47507 RVA: 0x001F2116 File Offset: 0x001F0316
		// (set) Token: 0x0600B994 RID: 47508 RVA: 0x001F211E File Offset: 0x001F031E
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

		// Token: 0x0600B995 RID: 47509 RVA: 0x001F2127 File Offset: 0x001F0327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SavePointsInfoNotify);
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x001F2135 File Offset: 0x001F0335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SavePointsInfoNotify other)
		{
			return other != null && (other == this || (this.ValidTimes == other.ValidTimes && this.RefreshTime == other.RefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x001F2174 File Offset: 0x001F0374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ValidTimes != 0U)
			{
				num ^= this.ValidTimes.GetHashCode();
			}
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x001F21CC File Offset: 0x001F03CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x001F21D4 File Offset: 0x001F03D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x001F21E0 File Offset: 0x001F03E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ValidTimes != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ValidTimes);
			}
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x001F223C File Offset: 0x001F043C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ValidTimes != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ValidTimes);
			}
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x001F2294 File Offset: 0x001F0494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SavePointsInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ValidTimes != 0U)
			{
				this.ValidTimes = other.ValidTimes;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x001F22E4 File Offset: 0x001F04E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x001F22F0 File Offset: 0x001F04F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RefreshTime = input.ReadInt64();
					}
				}
				else
				{
					this.ValidTimes = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004B22 RID: 19234
		private static readonly MessageParser<SavePointsInfoNotify> _parser = new MessageParser<SavePointsInfoNotify>(() => new SavePointsInfoNotify());

		// Token: 0x04004B23 RID: 19235
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004B24 RID: 19236
		public const int ValidTimesFieldNumber = 3;

		// Token: 0x04004B25 RID: 19237
		private uint validTimes_;

		// Token: 0x04004B26 RID: 19238
		public const int RefreshTimeFieldNumber = 10;

		// Token: 0x04004B27 RID: 19239
		private long refreshTime_;
	}
}
