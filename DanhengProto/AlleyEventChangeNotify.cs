using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200007F RID: 127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AlleyEventChangeNotify : IMessage<AlleyEventChangeNotify>, IMessage, IEquatable<AlleyEventChangeNotify>, IDeepCloneable<AlleyEventChangeNotify>, IBufferMessage
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000FCAD File Offset: 0x0000DEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AlleyEventChangeNotify> Parser
		{
			get
			{
				return AlleyEventChangeNotify._parser;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AlleyEventChangeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000FCC6 File Offset: 0x0000DEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AlleyEventChangeNotify.Descriptor;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000FCCD File Offset: 0x0000DECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventChangeNotify()
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventChangeNotify(AlleyEventChangeNotify other) : this()
		{
			this.hOAHHDCGEEO_ = ((other.hOAHHDCGEEO_ != null) ? other.hOAHHDCGEEO_.Clone() : null);
			this.aMFBGHLDGIH_ = other.aMFBGHLDGIH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000FD24 File Offset: 0x0000DF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AlleyEventChangeNotify Clone()
		{
			return new AlleyEventChangeNotify(this);
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000FD34 File Offset: 0x0000DF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKFJJBFEAPC HOAHHDCGEEO
		{
			get
			{
				return this.hOAHHDCGEEO_;
			}
			set
			{
				this.hOAHHDCGEEO_ = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0000FD3D File Offset: 0x0000DF3D
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0000FD45 File Offset: 0x0000DF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AMFBGHLDGIH
		{
			get
			{
				return this.aMFBGHLDGIH_;
			}
			set
			{
				this.aMFBGHLDGIH_ = value;
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AlleyEventChangeNotify);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AlleyEventChangeNotify other)
		{
			return other != null && (other == this || (object.Equals(this.HOAHHDCGEEO, other.HOAHHDCGEEO) && this.AMFBGHLDGIH == other.AMFBGHLDGIH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000FDAC File Offset: 0x0000DFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.hOAHHDCGEEO_ != null)
			{
				num ^= this.HOAHHDCGEEO.GetHashCode();
			}
			if (this.AMFBGHLDGIH != 0U)
			{
				num ^= this.AMFBGHLDGIH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000FE01 File Offset: 0x0000E001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000FE09 File Offset: 0x0000E009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000FE14 File Offset: 0x0000E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AMFBGHLDGIH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.AMFBGHLDGIH);
			}
			if (this.hOAHHDCGEEO_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.HOAHHDCGEEO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000FE70 File Offset: 0x0000E070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.hOAHHDCGEEO_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HOAHHDCGEEO);
			}
			if (this.AMFBGHLDGIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AMFBGHLDGIH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AlleyEventChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.hOAHHDCGEEO_ != null)
			{
				if (this.hOAHHDCGEEO_ == null)
				{
					this.HOAHHDCGEEO = new CKFJJBFEAPC();
				}
				this.HOAHHDCGEEO.MergeFrom(other.HOAHHDCGEEO);
			}
			if (other.AMFBGHLDGIH != 0U)
			{
				this.AMFBGHLDGIH = other.AMFBGHLDGIH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000FF30 File Offset: 0x0000E130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000FF3C File Offset: 0x0000E13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.hOAHHDCGEEO_ == null)
						{
							this.HOAHHDCGEEO = new CKFJJBFEAPC();
						}
						input.ReadMessage(this.HOAHHDCGEEO);
					}
				}
				else
				{
					this.AMFBGHLDGIH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000205 RID: 517
		private static readonly MessageParser<AlleyEventChangeNotify> _parser = new MessageParser<AlleyEventChangeNotify>(() => new AlleyEventChangeNotify());

		// Token: 0x04000206 RID: 518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000207 RID: 519
		public const int HOAHHDCGEEOFieldNumber = 10;

		// Token: 0x04000208 RID: 520
		private CKFJJBFEAPC hOAHHDCGEEO_;

		// Token: 0x04000209 RID: 521
		public const int AMFBGHLDGIHFieldNumber = 7;

		// Token: 0x0400020A RID: 522
		private uint aMFBGHLDGIH_;
	}
}
