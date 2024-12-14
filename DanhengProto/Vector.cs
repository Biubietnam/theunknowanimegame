using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001411 RID: 5137
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class Vector : IMessage<Vector>, IMessage, IEquatable<Vector>, IDeepCloneable<Vector>, IBufferMessage
	{
		// Token: 0x17004058 RID: 16472
		// (get) Token: 0x0600E529 RID: 58665 RVA: 0x00261670 File Offset: 0x0025F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<Vector> Parser
		{
			get
			{
				return Vector._parser;
			}
		}

		// Token: 0x17004059 RID: 16473
		// (get) Token: 0x0600E52A RID: 58666 RVA: 0x00261677 File Offset: 0x0025F877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return VectorReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700405A RID: 16474
		// (get) Token: 0x0600E52B RID: 58667 RVA: 0x00261689 File Offset: 0x0025F889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Vector.Descriptor;
			}
		}

		// Token: 0x0600E52C RID: 58668 RVA: 0x00261690 File Offset: 0x0025F890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector()
		{
		}

		// Token: 0x0600E52D RID: 58669 RVA: 0x00261698 File Offset: 0x0025F898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector(Vector other) : this()
		{
			this.y_ = other.y_;
			this.z_ = other.z_;
			this.x_ = other.x_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E52E RID: 58670 RVA: 0x002616D5 File Offset: 0x0025F8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Clone()
		{
			return new Vector(this);
		}

		// Token: 0x1700405B RID: 16475
		// (get) Token: 0x0600E52F RID: 58671 RVA: 0x002616DD File Offset: 0x0025F8DD
		// (set) Token: 0x0600E530 RID: 58672 RVA: 0x002616E5 File Offset: 0x0025F8E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x1700405C RID: 16476
		// (get) Token: 0x0600E531 RID: 58673 RVA: 0x002616EE File Offset: 0x0025F8EE
		// (set) Token: 0x0600E532 RID: 58674 RVA: 0x002616F6 File Offset: 0x0025F8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Z
		{
			get
			{
				return this.z_;
			}
			set
			{
				this.z_ = value;
			}
		}

		// Token: 0x1700405D RID: 16477
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x002616FF File Offset: 0x0025F8FF
		// (set) Token: 0x0600E534 RID: 58676 RVA: 0x00261707 File Offset: 0x0025F907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x00261710 File Offset: 0x0025F910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as Vector);
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x00261720 File Offset: 0x0025F920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(Vector other)
		{
			return other != null && (other == this || (this.Y == other.Y && this.Z == other.Z && this.X == other.X && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x0026177C File Offset: 0x0025F97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Z != 0)
			{
				num ^= this.Z.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E538 RID: 58680 RVA: 0x002617ED File Offset: 0x0025F9ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x002617F5 File Offset: 0x0025F9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x00261800 File Offset: 0x0025FA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0)
			{
				output.WriteRawTag(48);
				output.WriteSInt32(this.X);
			}
			if (this.Z != 0)
			{
				output.WriteRawTag(80);
				output.WriteSInt32(this.Z);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(120);
				output.WriteSInt32(this.Y);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x00261878 File Offset: 0x0025FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Y);
			}
			if (this.Z != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.Z);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.X);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x002618E8 File Offset: 0x0025FAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(Vector other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Z != 0)
			{
				this.Z = other.Z;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x0026194C File Offset: 0x0025FB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x00261958 File Offset: 0x0025FB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Y = input.ReadSInt32();
						}
					}
					else
					{
						this.Z = input.ReadSInt32();
					}
				}
				else
				{
					this.X = input.ReadSInt32();
				}
			}
		}

		// Token: 0x04005B07 RID: 23303
		private static readonly MessageParser<Vector> _parser = new MessageParser<Vector>(() => new Vector());

		// Token: 0x04005B08 RID: 23304
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B09 RID: 23305
		public const int YFieldNumber = 15;

		// Token: 0x04005B0A RID: 23306
		private int y_;

		// Token: 0x04005B0B RID: 23307
		public const int ZFieldNumber = 10;

		// Token: 0x04005B0C RID: 23308
		private int z_;

		// Token: 0x04005B0D RID: 23309
		public const int XFieldNumber = 6;

		// Token: 0x04005B0E RID: 23310
		private int x_;
	}
}
